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
    public partial class Form2 : Form
    {
        private int companyId;
        private string companyName;
        private double companyEmissions;
        public Form2(int companyId, string companyName, double companyEmissions)
        {
            InitializeComponent();
            this.companyId = companyId;
            this.companyName = companyName;
            this.companyEmissions = companyEmissions;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apiKey = "XcQBBciF5dVI0pa3B75bEg";  // Set your actual API key here
            CalculateEnergy dashboard = new CalculateEnergy(apiKey, companyId, companyName);
            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trading dashboard = new Trading(companyId, companyName, companyEmissions);
            dashboard.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
