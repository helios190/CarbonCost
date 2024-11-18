using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;


namespace CarbonCost.Tests
{
    [TestClass]
    public class CalculateEnergyTests
    {
        private Mock<ElectricityService> _mockElectricityService;

        [TestInitialize]
        public void Setup()
        {
            _mockElectricityService = new Mock<ElectricityService>("dummy_api_key");
        }

        [TestMethod]
        public async Task BtnCalculate_Click_ValidInputs_ShouldDisplayCorrectResult()
        {
            // Arrange
            var form = new CalculateEnergy("dummy_api_key");
            form.cmbElectricityUnit.Items.Add("mwh");
            form.cmbElectricityUnit.SelectedItem = "mwh";

            form.cmbCountry.Items.Add("us");
            form.cmbCountry.SelectedItem = "us";

            form.cmbState.Items.Add("fl");
            form.cmbState.SelectedItem = "fl";

            form.txtElectricityValue.Text = "100";

            _mockElectricityService
                .Setup(s => s.GetElectricityEmissionsAsync("mwh", 100, "us", "fl"))
                .ReturnsAsync(500); // Mock API response: 500 kg CO2

            // Act
            await form.btnCalculate_Click(null, null);

            // Assert
            Assert.IsTrue(form.lblResult.Text.Contains("500 kg CO2"));
            Assert.IsTrue(form.lblResult.Text.Contains("0.5 metric tons (MT)"));
        }

        [TestMethod]
        public void BtnCalculate_Click_InvalidElectricityValue_ShouldShowErrorMessage()
        {
            // Arrange
            var form = new CalculateEnergy("dummy_api_key");
            form.txtElectricityValue.Text = "";

            // Act
            form.btnCalculate_Click(null, null);

            // Assert
            Assert.IsTrue(form.lblResult.Text.Contains("Please enter a valid electricity value greater than zero."));
        }

        [TestMethod]
        public void BtnCalculate_Click_MissingDropdownSelection_ShouldShowErrorMessage()
        {
            // Arrange
            var form = new CalculateEnergy("dummy_api_key");
            form.txtElectricityValue.Text = "100";

            // Leave dropdowns unselected
            form.cmbElectricityUnit.SelectedItem = null;
            form.cmbCountry.SelectedItem = null;
            form.cmbState.SelectedItem = null;

            // Act
            form.btnCalculate_Click(null, null);

            // Assert
            Assert.IsTrue(form.lblResult.Text.Contains("Please make sure all dropdowns are selected."));
        }
    }
}
