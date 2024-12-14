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
                            double pricePerCredit = reader.GetDouble(3);
                            int quota = reader.GetInt32(4);
                            int excess = reader.GetInt32(0);

                            label7.Text = $"${excess:F2}";
                            label9.Text = $"{quota}";
                            label10.Text = $"{pricePerCredit:F2}";
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

                // SQL query to get the necessary details from the database
                sql = @"
                SELECT 
                (company_emissions - credit_amount) AS excess, 
                company_emissions,
                credit_amount,
                price_per_credit
                FROM 
                carbon_credit cc 
                JOIN 
                company c ON c.company_id = cc.company_id 
                WHERE 
                c.company_id = @companyId";

                // Prepare the command
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@companyId", companyId);

                // Execute the command and get the data reader
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Read the values from the reader
                        double pricePerCredit = reader.GetDouble(3);  // price_per_credit (4th column)
                        double companyEmissions = reader.GetDouble(1);  // company_emissions (2nd column)
                        double credits = reader.GetDouble(2);
                        double excess = reader.GetDouble(0);

                        // Check if there's enough emissions or credits
                        if (excess <= 0)
                        {
                            MessageBox.Show("Insufficient credits available for purchase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            conn.Close();
                            return;
                        }

                        // Calculate the total cost
                        double totalCost = creditAmount * pricePerCredit;

                        // Update emissions for the Buyer (increase emissions by the total cost)
                        companyEmissions += totalCost;
                        double newExcess = companyEmissions - credits;

                        // Close the connection after the first read
                        conn.Close();

                        // Reopen the connection for the second command
                        conn.Open();

                        // Update the Buyer’s emissions (company_emissions for the buyer)
                        sql = @"
                        UPDATE company 
                        SET company_emissions = company_emissions + @totalCost 
                        WHERE company_id = @companyId";

                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@totalCost", totalCost);
                        cmd.Parameters.AddWithValue("@companyId", companyId);  // Buyer ID (this.companyId is the current user's company ID)
                        cmd.ExecuteNonQuery();

                        // Update the Seller’s credit amount (reduce credits for the seller)
                        sql = @"
                        UPDATE company 
                        SET company_emissions = company_emissions - @totalCost 
                        WHERE company_id = @companyId";

                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@totalCost", totalCost); // Deduct purchased credits
                        cmd.Parameters.AddWithValue("@companyId", selectedCompanyId);  // Seller ID (selectedCompanyId is the company the buyer is purchasing from)
                        cmd.ExecuteNonQuery();

                        sql = @"
                INSERT INTO transactions 
                (transaction_type, buyer, company_id, amount, total)
                VALUES 
                (@transactionType, @buyer, @company_id, @amount, @totalAmount)";

                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@transactionType", "Buy");
                        cmd.Parameters.AddWithValue("@buyer", selectedCompanyId);  // Buyer ID
                        cmd.Parameters.AddWithValue("@company_id", companyId);  // Seller ID
                        cmd.Parameters.AddWithValue("@amount", creditAmount);
                        cmd.Parameters.AddWithValue("@totalAmount", totalCost);
                        cmd.ExecuteNonQuery();

                        // Recalculate new quota for the Buyer (optional, based on new emissions)
                        double newQuota = Math.Floor(newExcess / pricePerCredit);
                        label7.Text = $"${newExcess:F2}";
                        label9.Text = $"{newQuota:F0}";

                        conn.Close();

                        // Refresh the grid after the purchase
                        RefreshCarbonCreditGrid();

                        MessageBox.Show("Purchase successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Handle the case where no data was found
                        MessageBox.Show("No data found for the selected Company ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                    }
                }
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
                (company_emissions - credit_amount) AS excess, 
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
                        double credits = reader.GetDouble(2);
                        double excess = reader.GetDouble(0);

                        // Check if there is enough emissions for the sale
                        if (excess <= 0)
                        {
                            MessageBox.Show("Emissions are zero or negative. Cannot proceed with the sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            conn.Close();  // Close the connection if there's an issue
                            return;
                        }

                        // Calculate total revenue from the credit sale
                        double totalRevenue = creditAmount * pricePerCredit;
                        double newCompanyEmissions = companyEmissions - totalRevenue; // Calculate new emissions after the sale
                        double newExcess = newCompanyEmissions - credits;


                        // Check if the new emissions would be negative
                        if (newExcess < 0)
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

                        sql = @"
                INSERT INTO transactions 
                (transaction_type, buyer, company_id, amount, total)
                VALUES 
                (@transactionType, @buyer, @company_id, @amount, @totalAmount)";

                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@transactionType", "Sell");
                        cmd.Parameters.AddWithValue("@buyer", selectedCompanyId);  // Buyer ID
                        cmd.Parameters.AddWithValue("@company_id", companyId);  // Seller ID
                        cmd.Parameters.AddWithValue("@amount", creditAmount);
                        cmd.Parameters.AddWithValue("@totalAmount", totalRevenue);
                        cmd.ExecuteNonQuery();

                        // Calculate the new quota dynamically (and floor the value)
                        double newQuota = Math.Floor(newExcess / pricePerCredit);

                        // Close the connection after updates
                        conn.Close();

                        // Refresh the UI or DataGridView here
                        RefreshCarbonCreditGrid();  // Method to refresh the grid with the updated data

                        // Update the emissions label on UI
                        label7.Text = $"${newExcess:F2}";  // Update with the new emissions value

                        // Update Label9 with new quota information
                        label9.Text = $"{newQuota:F0}"; // Update label9 with the new quota value

                        // Ensure the UI refreshes correctly after all updates
                        this.Refresh(); // This will refresh the entire form, forcing UI controls to update

                        MessageBox.Show("Sale successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SELECT transaction_id,transaction_type,company_id,buyer,amount,total
                    FROM transactions
                    WHERE company_id = @companyId";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
