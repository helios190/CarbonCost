using System;
using System.Windows.Forms;
using CarbonCost;


namespace CarbonCost
{
    public partial class CalculateEnergy : Form
    {
        private readonly APIServices _apiServices;
        public CalculateEnergy(string apiKey)
        {
            InitializeComponent();
            _apiServices = new APIServices(apiKey);
        }


        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab.Text == "Electricity Consumption")
                {
                    // Electricity Emission Calculation
                    await CalculateElectricityEmissionsAsync();
                }
                else if (tabControl.SelectedTab.Text == "Shipping Habits")
                {
                    // Shipping Emission Calculation
                    await CalculateShippingEmissionsAsync();
                }
                else if (tabControl.SelectedTab.Text == "Fuel Combustion")
                {
                    // Fuel Combustion Emission Calculation
                    await CalculateFuelCombustionEmissionsAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        #region Electricity Emissions
        private async System.Threading.Tasks.Task CalculateElectricityEmissionsAsync()
        {
            if (!ValidateInput(txtElectricityValue.Text, out double value) ||
                cmbElectricityUnit.SelectedItem == null ||
                cmbCountry.SelectedItem == null)
            {
                ShowInputError();
                return;
            }

            string unit = cmbElectricityUnit.SelectedItem.ToString();
            string country = cmbCountry.SelectedItem.ToString();
            string state = cmbState.SelectedItem?.ToString() == "n/a" ? null : cmbState.SelectedItem.ToString();

            // API Service Call
            var result = await _apiServices.GetElectricityEmissionsAsync(unit, value, country, state);
        }
        #endregion

        #region Shipping Emissions
        private async System.Threading.Tasks.Task CalculateShippingEmissionsAsync()
        {
            if (!ValidateInput(txtWeightValue.Text, out double weight) ||
                !ValidateInput(txtDistanceValue.Text, out double distance) ||
                cbTransport.SelectedItem == null)
            {
                ShowInputError();
                return;
            }

            string transport = cbTransport.SelectedItem.ToString();
            string weightUnit = cbWeightUnit.SelectedItem.ToString();
            string distanceUnit = cbDistanceUnit.SelectedItem?.ToString();

            // API Service Call
            var result = await _apiServices.GetShippingEmissionsAsync(weight, weightUnit, distance, distanceUnit, transport);
            //lblResult.Text = $"Shipping Carbon Emissions:\n {result} kg CO2";
        }
        #endregion

        #region Fuel Combustion Emissions
        private async System.Threading.Tasks.Task CalculateFuelCombustionEmissionsAsync()
        {
            if (!ValidateInput(txtValueFuel.Text, out double quantity) ||
                cbSource.SelectedItem == null ||
                cbFuelUnit.SelectedItem == null)
            {
                ShowInputError();
                return;
            }

            string fuelType = ((KeyValuePair<string, string>)cbSource.SelectedItem).Value;
            string unit = cbFuelUnit.SelectedItem.ToString();

            // API Service Call
            var result = await _apiServices.GetFuelCombustionEmissionsAsync(fuelType, quantity, unit);
            //lblResult.Text = $"Fuel Combustion Carbon Emissions: {result} kg CO2";
        }
        #endregion

        #region Helpers
        private bool ValidateInput(string input, out double value)
        {
            //return !string.IsNullOrWhiteSpace(input) && double.TryParse(input, out value) && value > 0;
            // Always assign a default value to satisfy the compiler
            value = 0;

            if (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out double parsedValue) || parsedValue <= 0)
            {
                return false; // Validation failed
            }

            value = parsedValue;
            return true; // Validation successful
        }

        private void ShowInputError()
        {
            MessageBox.Show("Please ensure all fields are filled correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        // Dictionary to map fuel types (api_name) to their valid units
        private Dictionary<string, List<string>> fuelTypeUnits = new Dictionary<string, List<string>>()
        {
            { "bit", new List<string> { "short_ton", "btu" } },     // Bituminous Coal
            { "dfo", new List<string> { "gallon", "btu" } },       // Home Heating and Diesel Fuel
            { "jf", new List<string> { "gallon", "btu" } },        // Jet Fuel
            { "ker", new List<string> { "gallon", "btu" } },       // Kerosene
            { "lig", new List<string> { "short_ton", "btu" } },    // Lignite Coal
            { "msw", new List<string> { "short_ton", "btu" } },    // Municipal Solid Waste
            { "ng", new List<string> { "thousand_cubic_feet", "btu" } }, // Natural Gas
            { "pc", new List<string> { "gallon", "btu" } },        // Petroleum Coke
            { "pg", new List<string> { "gallon", "btu" } },        // Propane Gas
            { "rfo", new List<string> { "gallon", "btu" } },       // Residual Fuel Oil
            { "sub", new List<string> { "short_ton", "btu" } },    // Subbituminous Coal
            { "tdf", new List<string> { "short_ton", "btu" } },    // Tire-Derived Fuel
            { "wo", new List<string> { "barrel", "btu" } },        // Waste Oil
        };

        private void PopulateUnitDropdown(string fuelTypeApiName)
        {
            // Clear existing items
            cbFuelUnit.Items.Clear();

            // Add valid units based on selected fuel type
            if (fuelTypeUnits.ContainsKey(fuelTypeApiName))
            {
                foreach (var unit in fuelTypeUnits[fuelTypeApiName])
                {
                    cbFuelUnit.Items.Add(unit);
                }
                cbFuelUnit.SelectedIndex = 0; // Default selection
            }
        }

        private void PopulateFuelTypeDropdown()
        {
            // Clear existing items
            cbSource.Items.Clear();

            // Add fuel types as KeyValuePairs
            cbSource.Items.Add(new KeyValuePair<string, string>("Bituminous Coal", "bit"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Home Heating and Diesel Fuel", "dfo"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Jet Fuel", "jf"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Kerosene", "ker"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Lignite Coal", "lig"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Municipal Solid Waste", "msw"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Natural Gas", "ng"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Petroleum Coke", "pc"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Propane Gas", "pg"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Residual Fuel Oil", "rfo"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Subbituminous Coal", "sub"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Tire-Derived Fuel", "tdf"));
            cbSource.Items.Add(new KeyValuePair<string, string>("Waste Oil", "wo"));

            // Configure ComboBox
            cbSource.DisplayMember = "Key";  // Display fuel type name
            cbSource.ValueMember = "Value";  // Actual api_name
            cbSource.SelectedIndex = 0;      // Default selection

            // Event handler for selection change to populate units
            cbSource.SelectedIndexChanged += cbSource_SelectedIndexChanged;

            // Populate units for default selection
            PopulateUnitDropdown(((KeyValuePair<string, string>)cbSource.SelectedItem).Value);
        }

        private void cbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected fuel type's api_name
            var selectedFuel = (KeyValuePair<string, string>)cbSource.SelectedItem;
            PopulateUnitDropdown(selectedFuel.Value);
        }

        private void CalculateEnergy_Load(object sender, EventArgs e)
        {
            // Populate dropdowns
            cmbElectricityUnit.Items.AddRange(new string[] { "mwh", "kwh" });
            cmbElectricityUnit.SelectedIndex = 0;

            cmbCountry.Items.AddRange(new string[] { "us", "gb", "ca", "de" });
            cmbCountry.SelectedIndex = 0;
            cmbState.Items.Add("fl"); // Florida
            cmbState.Items.Add("ca"); // California
            cmbState.Items.Add("ny"); // New York
            cmbState.SelectedIndex = 0;

            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged;

            cbTransport.Items.AddRange(new string[] { "ship", "plane", "truck", "train" });
            cbTransport.SelectedIndex = 0;
            cbDistanceUnit.Items.AddRange(new string[] { "mi", "km" });
            cbDistanceUnit.SelectedIndex = 0;
            cbWeightUnit.Items.AddRange(new string[] { "g", "lb", "kg", "mt" });
            cbWeightUnit.SelectedIndex = 0;

            PopulateFuelTypeDropdown();
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
