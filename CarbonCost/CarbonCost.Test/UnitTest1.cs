using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CarbonCost; // Namespace of your main project
using System.Threading.Tasks;

namespace CarbonCost.Test
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

            // Mock combo box and text box inputs
            form.cmbElectricityUnit.Items.Add("mwh");
            form.cmbElectricityUnit.SelectedItem = "mwh";

            form.cmbCountry.Items.Add("us");
            form.cmbCountry.SelectedItem = "us";

            form.cmbState.Items.Add("fl");
            form.cmbState.SelectedItem = "fl";

            form.txtElectricityValue.Text = "100";

            // Mock the API response
            _mockElectricityService
                .Setup(s => s.GetElectricityEmissionsAsync("mwh", 100, "us", "fl"))
                .ReturnsAsync(500); // Mock 500 kg CO2 as the return value

            // Act
            await form.btnCalculate_Click(null, null);

            // Assert
            Assert.IsTrue(form.lblResult.Text.Contains("500 kg CO2"));
            Assert.IsTrue(form.lblResult.Text.Contains("0.5 metric tons (MT)"));
        }
    }
}
