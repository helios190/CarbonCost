using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonCost
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            LoadIndustries();
        }
        private void LoadIndustries()
        {
            // Define a list of industries
            string[] industries = new string[]
            {
                "Technology",
                "Healthcare",
                "Finance",
                "Education",
                "Retail",
                "Manufacturing",
                "Transportation",
                "Construction",
                "Energy",
                "Entertainment"
            };

            // Populate the ComboBox
            comboBox1.Items.AddRange(industries);

            // Optionally, set the default selected item
            comboBox1.SelectedIndex = 0; // Select the first item
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string companyName = textBox2.Text.Trim(); // Replace txtCompanyName with your TextBox name
            string username = tbUsername.Text.Trim();       // Replace txtUsername with your TextBox name
            string password = tbPassword.Text.Trim();       // Replace txtPassword with your TextBox name
            string confirmPassword = textBox1.Text.Trim();

            // Validate the inputs
            if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected industry and set the credit amount based on the industry
            string selectedIndustry = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedIndustry))
            {
                MessageBox.Show("Please select an industry!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Define credit amounts for industries
            var industryCredits = new Dictionary<string, int>
            {
        { "Technology", 300 },
        { "Healthcare", 250 },
        { "Finance", 400 },
        { "Education", 200 },
        { "Retail", 150 },
        { "Manufacturing", 350 },
        { "Transportation", 500 },
        { "Construction", 300 },
        { "Energy", 600 },
        { "Entertainment", 100 }
    };

            // Get the credit amount for the selected industry
            int creditAmount = industryCredits.ContainsKey(selectedIndustry) ? industryCredits[selectedIndustry] : 200; // Default to 200 if not found

            // Database connection string
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Marvel_123;Database=carboncost";

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to insert the new company
                    string insertQuery = @"
                INSERT INTO company (company_name, company_accounts, company_password, company_emissions)
                VALUES (@companyName, @username, @password, 0)
                RETURNING company_id;";

                    using (var command = new NpgsqlCommand(insertQuery, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("companyName", companyName);
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("password", password);

                        // Execute the query and get the newly created company_id
                        var newCompanyId = command.ExecuteScalar();

                        MessageBox.Show($"Company registered successfully! Your Company ID is {newCompanyId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // SQL query to update the carbon credit for the newly created company
                        string updateCreditQuery = @"
                    INSERT INTO carbon_credit(credit_amount, company_id, price_per_credit)
                    VALUES (@creditAmount, @companyId, 0)";

                        using (var updateCommand = new NpgsqlCommand(updateCreditQuery, connection))
                        {
                            // Add parameters for the credit amount and company ID
                            updateCommand.Parameters.AddWithValue("creditAmount", creditAmount);
                            updateCommand.Parameters.AddWithValue("companyId", newCompanyId);

                            // Execute the update query
                            updateCommand.ExecuteNonQuery();
                        }

                        // Optionally clear the textboxes after success
                        textBox2.Clear();
                        tbUsername.Clear();
                        tbPassword.Clear();
                        textBox1.Clear();

                        this.Hide();
                        homepage dashboard = new homepage();
                        dashboard.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
