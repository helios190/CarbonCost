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
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=Marvel_123;Database=carboncost";
        private NpgsqlConnection conn;
        private DataGridViewRow r;
        public static NpgsqlCommand cmd;
        private string companyProfile = "Company A"; // Static company profile
        public double limit = 1000.0; // Initial limit value
        public string sql = null;
        public DataTable dt;
        public Trading()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void Trading_Load(object sender, EventArgs e)
        {
            label6.Text = companyProfile; // Set company profile
            label7.Text = $"${limit:F2}"; // Set initial limit with two decimal places
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = "SELECT _credit_id, _credit_amount, _price_per_credit, _company_id FROM st_select_carbon_credit()";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt; // Bind the result to the DataGridView
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                r = dataGridView2.Rows[e.RowIndex]; // Store the selected row in variable `r`
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

            if (string.IsNullOrWhiteSpace(txtCompanyId.Text) || !int.TryParse(txtCompanyId.Text, out int companyId))
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

                // Get the price per credit for the given company ID
                sql = "select * from st_buy_carbon_credit((select credit_id from carbon_credit where company_id = :_company_id), :_buy_amount)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_company_id", companyId);

                double pricePerCredit = Convert.ToDouble(cmd.ExecuteScalar());
                if (pricePerCredit <= 0)
                {
                    MessageBox.Show("Invalid price per credit for the selected Company ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                // Calculate the total cost
                double totalCost = creditAmount * pricePerCredit;

                // Check if the total cost exceeds the current limit
                if (totalCost > limit)
                {
                    MessageBox.Show($"Purchase cost (${totalCost:F2}) exceeds your current limit (${limit:F2}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                // Proceed with the purchase
                sql = "select * from st_buy_carbon_credit((select credit_id from carbon_credit where company_id = :_company_id), :_buy_amount)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_company_id", companyId);
                cmd.Parameters.AddWithValue("_buy_amount", creditAmount);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    // Deduct the total cost from the limit
                    limit -= totalCost;
                    label7.Text = $"${limit:F2}"; // Update the limit display

                    MessageBox.Show("Purchase successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshCarbonCreditGrid(); // Refresh the grid to show updated values
                    txtAmount.Text = txtCompanyId.Text = string.Empty; // Clear inputs
                }
                else
                {
                    MessageBox.Show("Not enough credits available to complete the purchase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCompanyId.Text) || !int.TryParse(txtCompanyId.Text, out int companyId))
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
                conn.Open();

                // Get the price per credit for the given company ID
                sql = "SELECT price_per_credit FROM carbon_credit WHERE company_id = :_company_id";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_company_id", companyId);

                double pricePerCredit = Convert.ToDouble(cmd.ExecuteScalar());
                if (pricePerCredit <= 0)
                {
                    MessageBox.Show("Invalid price per credit for the selected Company ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                // Calculate the total revenue
                double totalRevenue = creditAmount * pricePerCredit;

                // Proceed with the sale
                sql = "select * from st_sell_carbon_credit((select credit_id from carbon_credit where company_id = :_company_id), :_sell_amount)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_company_id", companyId);
                cmd.Parameters.AddWithValue("_sell_amount", creditAmount);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    // Add the total revenue to the limit
                    limit += totalRevenue;
                    label7.Text = $"${limit:F2}"; // Update the limit display

                    MessageBox.Show("Sale successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshCarbonCreditGrid(); // Refresh the grid to show updated values
                    txtAmount.Text = txtCompanyId.Text = string.Empty; // Clear inputs
                }
                else
                {
                    MessageBox.Show("Failed to sell credits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshCarbonCreditGrid()
        {
            try
            {
                sql = "SELECT _credit_id, _credit_amount, _price_per_credit, _company_id FROM st_select_carbon_credit()";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt; // Rebind the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
