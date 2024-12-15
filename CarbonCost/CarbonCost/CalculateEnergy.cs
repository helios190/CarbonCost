using System;
using System.ComponentModel.Design;
using System.Windows.Forms;
using CarbonCost;
using Npgsql;


namespace CarbonCost
{
    public partial class CalculateEnergy : Form
    {
        private readonly APIServices _apiServices;
        private readonly CompanyRepository _repository;
        private readonly string _companyName;
        private readonly int _companyId;

        public CalculateEnergy(string apiKey, int companyId, string companyName)
        {
            InitializeComponent();
            _apiServices = new APIServices(apiKey);
            var connectionFactory = new NpgsqlConnectionFactory("Host=localhost;Port=5432;Username=postgres;Password=Marvel_123;Database=carboncost");
            _repository = new CompanyRepository(connectionFactory);
            _companyId = companyId;
            _companyName = companyName;
        }


        private async void btnCalculate_Click_1(object sender, EventArgs e)
        {
            IEmissionCalculator calculator = null;

            try
            {
                if (tabControl.SelectedTab.Text == "Electricity Consumption")
                {
                    calculator = new ElectricityCalculator(_apiServices, cmbElectricityUnit.SelectedItem.ToString(), double.Parse(txtElectricityValue.Text), cmbCountry.SelectedItem.ToString());
                    label26.Text = $"{await calculator.CalculateEmissionsAsync():F2}";
                }
                else if (tabControl.SelectedTab.Text == "Shipping Habits")
                {
                    calculator = new ShippingCalculator(_apiServices, double.Parse(txtWeightValue.Text), double.Parse(txtDistanceValue.Text), cbTransport.SelectedItem.ToString(), cbWeightUnit.SelectedItem.ToString(), cbDistanceUnit.SelectedItem.ToString());
                    label24.Text = $"{await calculator.CalculateEmissionsAsync():F2}";
                }
                else if (tabControl.SelectedTab.Text == "Fuel Combustion")
                {
                    calculator = new FuelCalculator(_apiServices, ((KeyValuePair<string, string>)cbSource.SelectedItem).Value, double.Parse(txtValueFuel.Text), cbFuelUnit.SelectedItem.ToString());
                    label25.Text = $"{await calculator.CalculateEmissionsAsync():F2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double electricity = double.TryParse(label26.Text, out double g) ? g : 0;
            double shipping = double.TryParse(label24.Text, out double s) ? s : 0;
            double fuel = double.TryParse(label25.Text, out double f) ? f : 0;

            double average = (electricity + shipping + fuel) / 3;
            label27.Text = $"{average:F2}";

            // Update the database using the repository
            _repository.UpdateCompanyEmissions(_companyId, average);

            MessageBox.Show($"The Carbon Emissions in this Company is: {average:F2} kg CO2", "Average Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //#region Electricity Emissions
        //private async System.Threading.Tasks.Task<double> CalculateElectricityEmissionsAsync()
        //{
        //    if (!ValidateInput(txtElectricityValue.Text, out double value) ||
        //        cmbElectricityUnit.SelectedItem == null ||
        //        cmbCountry.SelectedItem == null)
        //    {
        //        ShowInputError();
        //        return 0;
        //    }

        //    string unit = cmbElectricityUnit.SelectedItem.ToString();
        //    string country = cmbCountry.SelectedItem.ToString();
        //    string state = cmbState.SelectedItem?.ToString() == "n/a" ? null : cmbState.SelectedItem.ToString();

        //    // API Service Call
        //    var result = await _apiServices.GetElectricityEmissionsAsync(unit, value, country, state);
        //    return result;
        //}
        //#endregion

        //#region Shipping Emissions
        //private async System.Threading.Tasks.Task<double> CalculateShippingEmissionsAsync()
        //{
        //    if (!ValidateInput(txtWeightValue.Text, out double weight) ||
        //        !ValidateInput(txtDistanceValue.Text, out double distance) ||
        //        cbTransport.SelectedItem == null)
        //    {
        //        ShowInputError();
        //        return 0; // Return a default value in case of validation failure
        //    }

        //    string transport = cbTransport.SelectedItem.ToString();
        //    string weightUnit = cbWeightUnit.SelectedItem.ToString();
        //    string distanceUnit = cbDistanceUnit.SelectedItem?.ToString();

        //    // API Service Call
        //    var result = await _apiServices.GetShippingEmissionsAsync(weight, weightUnit, distance, distanceUnit, transport);
        //    return result; // Now properly returning the result
        //}

        ////lblResult.Text = $"Shipping Carbon Emissions:\n {result} kg CO2";
        //#endregion

        //#region Fuel Combustion Emissions
        //private async System.Threading.Tasks.Task<double> CalculateFuelCombustionEmissionsAsync()
        //{
        //    if (!ValidateInput(txtValueFuel.Text, out double quantity) ||
        //        cbSource.SelectedItem == null ||
        //        cbFuelUnit.SelectedItem == null)
        //    {
        //        ShowInputError();
        //        return 0;
        //    }

        //    string fuelType = ((KeyValuePair<string, string>)cbSource.SelectedItem).Value;
        //    string unit = cbFuelUnit.SelectedItem.ToString();

        //    // API Service Call
        //    var result = await _apiServices.GetFuelCombustionEmissionsAsync(fuelType, quantity, unit);
        //    return result;
        //    //lblResult.Text = $"Fuel Combustion Carbon Emissions: {result} kg CO2";
        //}
        //#endregion

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

        private void cbTransport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Parse the values from the labels
        //        double electricity = double.TryParse(label26.Text, out double eValue) ? eValue : 0;
        //        double shipping = double.TryParse(label24.Text, out double sValue) ? sValue : 0;
        //        double fuel = double.TryParse(label25.Text, out double fValue) ? fValue : 0;

        //        // Calculate the average
        //        double average = (electricity + shipping + fuel) / 3;

        //        // Display the result in label27
        //        label27.Text = $"{average:F2}";

        //        // Show the result in a MessageBox
        //        MessageBox.Show($"The Carbon Emissions in this Company is: {average:F2} kg CO2",
        //                        "Average Result",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Information);

        //        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=Marvel_123;Database=carboncost";
        //        string query = "UPDATE company SET company_emissions = @average WHERE company_id = @companyId";
        //        using (var conn = new NpgsqlConnection(connstring))
        //        {
        //            conn.Open();

        //            using (var cmd = new NpgsqlCommand(query, conn))
        //            {
        //                // Add parameters to avoid SQL injection
        //                cmd.Parameters.AddWithValue("@average", average);
        //                cmd.Parameters.AddWithValue("@companyId", _companyId);

        //                // Execute the query
        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                if (rowsAffected > 0)
        //                {
        //                    MessageBox.Show($"Average emissions successfully updated for Company ID: {_companyId}!",
        //                                "Database Update",
        //                                MessageBoxButtons.OK,
        //                                MessageBoxIcon.Information);
        //                }
        //                else
        //                {
        //                    MessageBox.Show($"No record found for Company ID: {_companyId}.",
        //                                "Update Failed",
        //                                MessageBoxButtons.OK,
        //                                MessageBoxIcon.Warning);
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Database Error: {ex.Message}");
        //        MessageBox.Show($"Database Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            double average = double.TryParse(label27.Text, out double fValue) ? fValue : 0;
            Form2 dashboard = new Form2(_companyId, _companyName,average);
            dashboard.Show();
            this.Hide();
        }
    }
}
