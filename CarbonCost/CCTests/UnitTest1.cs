using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using CarbonCost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CCTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            // Mock the ElectricityService
            _mockElectricityService = new Mock<ElectricityService>("dummy_api_key");

            // Inject the mock into the form
            _form = new CalculateEnergy("dummy_api_key");
        }

        private Mock<ElectricityService> _mockElectricityService;
        private CalculateEnergy _form;
        [TestMethod]
        public async Task BtnCalculate_Click_ValidInput_ShowsCorrectResult()
        {
            // Arrange
            _mockElectricityService
                .Setup(service => service.GetElectricityEmissionsAsync("kwh", 100, "us", "ca"))
                .ReturnsAsync(50.0); // Mock API to return 50 kg CO2

            // Simulate form inputs
            _form.txtElectricityValue.Text = "100";
            _form.cmbElectricityUnit.SelectedItem = "kwh";
            _form.cmbCountry.SelectedItem = "us";
            _form.cmbState.SelectedItem = "ca";

            // Act
            _form.btnCalculate.PerformClick();

            // Wait for async operations to complete
            await Task.Delay(100); // Adjust delay based on async operation

            // Assert
            Assert.AreEqual(
                "Carbon Emission Estimate:\n- 50 kg CO2\n- 0.05 metric tons (MT)",
                _form.lblResult.Text
            );
        }
    }
}