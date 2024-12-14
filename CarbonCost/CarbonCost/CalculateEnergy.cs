using System;
using System.Windows.Forms;
using CarbonCost;


namespace CarbonCost
{
    public partial class CalculateEnergy : Form
    {
        private readonly string _apiKey = "XcQBBciF5dVI0pa3B75bEg";
        public CalculateEnergy(string apiKey)
        {
            InitializeComponent();
            _apiKey = apiKey;
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtElectricityValue.Text) || !double.TryParse(txtElectricityValue.Text, out double value) || value <= 0)
                {
                    MessageBox.Show("Please enter a valid electricity value greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbElectricityUnit.SelectedItem == null || cmbCountry.SelectedItem == null || cmbState.SelectedItem == null)
                {
                    MessageBox.Show("Please make sure all dropdowns are selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Get values from UI
                string unit = cmbElectricityUnit.SelectedItem.ToString();
                string country = cmbCountry.SelectedItem.ToString();
                string state = cmbState.SelectedItem?.ToString();
                if (state == "n/a") state = null; // Handle cases where no state applies

                // Call API
                var electricityService = new CarbonCost.ElectricityService(_apiKey);
                double carbonEmissionsKg = await electricityService.GetElectricityEmissionsAsync(unit, value, country, state);



                // Display results
                lblResult.Text = $"Carbon Emission Estimate:\n" +
                                 $"- {carbonEmissionsKg} kg CO2\n" +
                                 $"- {carbonEmissionsKg / 1000} metric tons (MT)";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalculateEnergy_Load(object sender, EventArgs e)
        {
            cmbElectricityUnit.Items.Add("mwh");
            cmbElectricityUnit.Items.Add("kwh");
            cmbElectricityUnit.SelectedIndex = 0;

            cmbCountry.Items.Add("us"); // United States
            cmbCountry.Items.Add("gb"); // United Kingdom
            cmbCountry.Items.Add("ca"); // Canada
            cmbCountry.Items.Add("de"); // Germany
            cmbCountry.SelectedIndex = 0;

            cmbState.Items.Add("fl"); // Florida
            cmbState.Items.Add("ca"); // California
            cmbState.Items.Add("ny"); // New York
            cmbState.SelectedIndex = 0;

            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged;
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbState.Items.Clear();

            if (cmbCountry.SelectedItem.ToString() == "us")
            {
                cmbState.Items.Add("fl");
                cmbState.Items.Add("ca");
                cmbState.Items.Add("ny");
            }
            else if (cmbCountry.SelectedItem.ToString() == "ca")
            {
                cmbState.Items.Add("on");
                cmbState.Items.Add("qc");
                cmbState.Items.Add("bc");
            }
            else
            {
                cmbState.Items.Add("n/a");
            }

            cmbState.SelectedIndex = 0;
        }

    }
}
