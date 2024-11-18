using System;
using System.Windows.Forms;
using CarbonCost;
using static System.Windows.Forms.DataFormats;

namespace CarbonCost
{
    public partial class CalculateEnergy : Form
    {
        CarbonCreditCapCalculator calculator;
        public CalculateEnergy()
        {
            InitializeComponent();

            calculator = new CarbonCreditCapCalculator();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.EnergyConsumption = Convert.ToDouble(tbEnergy.Text);
                calculator.TransportationHabits = Convert.ToDouble(tbTransport.Text);
                calculator.ProductionMetrics = Convert.ToDouble(tbMetric.Text);

                double cap = calculator.CalculationCap();

                MessageBox.Show($"Carbon Credit Cap: {cap}", "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void CalculateEnergy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
