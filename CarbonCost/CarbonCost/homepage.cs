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
using Npgsql;

namespace CarbonCost
{
    public partial class homepage : Form
    {
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=Marvel_123;Database=carboncost";
        private NpgsqlConnection conn;

        public homepage()
        {
            InitializeComponent();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            try
            {
                // Connect to the database
                using (var connection = new NpgsqlConnection(connstring))
                {
                    connection.Open();

                    // SQL query to get company details
                    string query = @"
                SELECT company_id, company_name, company_emissions 
                FROM company 
                WHERE company_accounts = @username AND company_password = @password";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("password", password);

                        // Execute the query and get the company details
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int companyId = reader.GetInt32(0);
                                string companyName = reader.GetString(1);
                                double companyEmissions = reader.GetDouble(2);

                                // Successful login
                                MessageBox.Show($"Welcome {companyName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Pass data to Form2
                                Form2 dashboard = new Form2(companyId, companyName, companyEmissions);
                                dashboard.Show();

                                // Hide the current form
                                this.Hide();
                            }
                            else
                            {
                                // Invalid credentials
                                MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register dashboard = new Register();
            dashboard.Show();
            this.Hide();
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
