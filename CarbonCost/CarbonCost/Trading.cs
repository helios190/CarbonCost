using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CarbonCost
{
    public partial class Trading : Form
    {
        private int companyId;
        private string companyName;
        private double companyEmissions;

        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=Marvel_123;Database=carboncost";
        private NpgsqlConnection conn;
        private DataGridViewRow r;
        public static NpgsqlCommand cmd;
        public string sql = null;
        public DataTable dt;

        public Trading(int companyId, string companyName, double companyEmissions)
        {
            InitializeComponent();
            LoadComboBox();
            this.companyId = companyId;
            this.companyName = companyName;
            this.companyEmissions = companyEmissions;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                txtCompanyId.Text = selectedRow.Cells["_company_id"].Value.ToString();
            }
        }

        private void Trading_Load(object sender, EventArgs e)
        {
            label6.Text = companyName; // Set company name
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"
        SELECT
            c.company_id,
            c.company_name,  
            ABS(CAST((c.company_emissions - cc.credit_amount) / NULLIF(cc.price_per_credit, 0) AS INTEGER)) AS quota, 
            cc.price_per_credit,
            (c.company_emissions - cc.credit_amount) AS excess
        FROM 
            company c
        JOIN 
            carbon_credit cc ON c.company_id = cc.company_id
        WHERE 
            c.company_name <> @companyName
            AND ABS(CAST((c.company_emissions - cc.credit_amount) / NULLIF(cc.price_per_credit, 0) AS INTEGER)) > 0
            AND (c.company_emissions - cc.credit_amount) / NULLIF(cc.price_per_credit, 0) > 0";

                using (var command = new NpgsqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@companyName", companyName);
                    using (var da = new NpgsqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt; // Bind the result to the DataGridView
                    }
                }

                // Fetch and set the price_per_credit and quota for the company
                sql = @"SELECT 
            (company_emissions - credit_amount) AS excess,
            company_emissions,
            credit_amount,
            price_per_credit,
            FLOOR(ABS((company_emissions - credit_amount) / NULLIF(price_per_credit, 0))) AS quota 
        FROM 
            carbon_credit cc 
        JOIN 
            company c ON c.company_id = cc.company_id 
        WHERE 
            c.company_name = @companyName";
                using (var command = new NpgsqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@companyName", companyName);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double pricePerCredit = reader.GetDouble(3);  // Get price_per_credit (column 3)
                            int quota = reader.GetInt32(4);  // Get quota (column 4), as FLOOR ensures it's an integer
                            int excess = reader.GetInt32(0);

                            label7.Text = $"${excess:F2}"; // Set company emissions
                            label9.Text = $"{quota}";  // Set Quota Label
                            label10.Text = $"{pricePerCredit:F2}";  // Set Price per Credit Label
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBox()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT _company_id FROM st_select_carbon_credit()";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxCompany.Items.Add(reader["_company_id"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading combo box: " + ex.Message);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompanyId.Text) || !int.TryParse(txtCompanyId.Text, out int selectedCompanyId))
            {
                MessageBox.Show("Please enter a valid Company ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text) || !double.TryParse(txtAmount.Text, out double creditAmount))
            {
                MessageBox.Show("Please enter a valid amount of credits to buy.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                // Get the price per credit for the selected company ID
                sql = "SELECT price_per_credit FROM carbon_credit WHERE company_id = @companyId";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@companyId", selectedCompanyId);

                double pricePerCredit = Convert.ToDouble(cmd.ExecuteScalar());
                if (pricePerCredit <= 0)
                {
                    MessageBox.Show("Invalid price per credit for the selected Company ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                // Calculate the total cost
                double totalCost = creditAmount * pricePerCredit;

                // Update emissions and database
                companyEmissions += totalCost;
                label7.Text = $"${companyEmissions:F2}";

                // Decrease quota by 1
                sql = @"
                UPDATE carbon_credit 
                SET credit_amount = credit_amount - @creditAmount 
                WHERE company_id = @companyId";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@creditAmount", creditAmount);
                cmd.Parameters.AddWithValue("@companyId", selectedCompanyId);
                cmd.ExecuteNonQuery();

                RefreshCarbonCreditGrid();
                MessageBox.Show("Purchase successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompanyId.Text) || !int.TryParse(txtCompanyId.Text, out int selectedCompanyId))
            {
                MessageBox.Show("Please enter a valid Company ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text) || !double.TryParse(txtAmount.Text, out double creditAmount))
            {
                MessageBox.Show("Please enter a valid amount of credits to sell.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Open the connection to fetch the initial data
                conn.Open();

                // Get the price per credit, excess, and quota for the selected company ID
                sql = @"
            SELECT 
                CAST((company_emissions - credit_amount) AS INTEGER) AS excess, 
                company_emissions,
                credit_amount,
                price_per_credit
            FROM 
                carbon_credit cc 
            JOIN 
                company c ON c.company_id = cc.company_id 
            WHERE 
                c.company_id = @companyId";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@companyId", selectedCompanyId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        double pricePerCredit = reader.GetDouble(3); // Get price per credit (column 3)
                        double companyEmissions = reader.GetDouble(1); // Get company emissions (column 1)

                        // Check if there is enough emissions for the sale
                        if (companyEmissions <= 0)
                        {
                            MessageBox.Show("Emissions are zero or negative. Cannot proceed with the sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            conn.Close();  // Close the connection if there's an issue
                            return;
                        }

                        // Calculate total revenue from the credit sale
                        double totalRevenue = creditAmount * pricePerCredit;
                        double newCompanyEmissions = companyEmissions - totalRevenue; // Calculate new emissions after the sale

                        // Check if the new emissions would be negative
                        if (newCompanyEmissions < 0)
                        {
                            MessageBox.Show("Selling this amount will result in negative emissions. Cannot proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            conn.Close();  // Close the connection if emissions would be negative
                            return;
                        }

                        // Now that everything is checked, close the current connection before making changes to emissions
                        conn.Close();

                        // Open a new connection for the update process
                        conn.Open();

                        // Proceed with the sale and reduce the company emissions
                        sql = @"
                    UPDATE company 
                    SET company_emissions = company_emissions - @totalRevenue 
                    WHERE company_id = @companyId";

                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@totalRevenue", totalRevenue);  // The total value to be deducted from emissions
                        cmd.Parameters.AddWithValue("@companyId", selectedCompanyId);
                        cmd.ExecuteNonQuery();

                        // Calculate the new quota dynamically (no database update needed)
                        double newQuota = newCompanyEmissions / pricePerCredit;

                        // Close the connection after updates
                        conn.Close();

                        // Refresh the UI or DataGridView here
                        RefreshCarbonCreditGrid();  // Method to refresh the grid with the updated data

                        // Update the emissions label on UI
                        label7.Text = $"${newCompanyEmissions:F2}";  // Update with the new emissions value

                        // Display the new quota dynamically on the UI
                        MessageBox.Show($"Sale successful! New Quota: {newQuota:F2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Could not retrieve credit information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();  // Close the connection in case of error
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();  // Ensure the connection is closed if an error occurs
            }
        }








        private void RefreshCarbonCreditGrid()
        {
            // Refresh the grid after a successful transaction
            conn.Open();
            sql = @"
                SELECT
                    c.company_id,
                    c.company_name,
                    ABS(CAST((c.company_emissions - cc.credit_amount) / NULLIF(cc.price_per_credit, 0) AS INTEGER)) AS quota, 
                    cc.price_per_credit,
                    (c.company_emissions - cc.credit_amount) AS excess
                FROM 
                    company c
                JOIN 
                    carbon_credit cc ON c.company_id = cc.company_id
                WHERE 
                    c.company_name <> @companyName
                    AND ABS(CAST((c.company_emissions - cc.credit_amount) / NULLIF(cc.price_per_credit, 0) AS INTEGER)) > 0
                    AND (c.company_emissions - cc.credit_amount) / NULLIF(cc.price_per_credit, 0) > 0";

            using (var command = new NpgsqlCommand(sql, conn))
            {
                command.Parameters.AddWithValue("@companyName", companyName);
                using (var da = new NpgsqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;  // Bind the updated result to the DataGridView
                }
            }
            conn.Close();
        }



private void load_Click(object sender, EventArgs e)
        {
            if (comboBoxCompany.SelectedItem == null)
            {
                MessageBox.Show("Please select a company.");
                return;
            }

            // Convert the selected company ID to an integer
            int selectedCompanyId;
            if (!int.TryParse(comboBoxCompany.SelectedItem.ToString(), out selectedCompanyId))
            {
                MessageBox.Show("Invalid company ID. Please select a valid company.");
                return;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    string query = @"
                SELECT _transaction_id, _transaction_type, _credit_amount, _price_per_credit,_company_id,_buyer
                FROM st_select_transactions()
                WHERE _company_id = @companyId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Pass the integer value as a parameter
                        cmd.Parameters.AddWithValue("@companyId", selectedCompanyId);

                        // Fill the data grid with the result
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid data: " + ex.Message);
            }
        }



        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
