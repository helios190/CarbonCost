using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using CarbonCost;

namespace CarbonCost.Tests
{
    [TestClass]
    public sealed class Test3
    {
        [TestMethod]
        public async Task ElectricityCalculator_ShouldReturnCorrectEmissions()
        {
            // Arrange
            var mockApiService = new Mock<IAPIServices>();
            mockApiService
                .Setup(api => api.GetElectricityEmissionsAsync("mwh", 1, "us", null))
                .ReturnsAsync(403.27);

            var calculator = new ElectricityCalculator(mockApiService.Object, "mwh", 1, "us");

            // Act
            var result = await calculator.CalculateEmissionsAsync();

            // Assert
            Assert.AreEqual(403.27, result, "The calculated emissions should match the expected value.");
        }

        [TestMethod]
        public async Task FuelCalculator_ShouldReturnCorrectEmissions()
        {
            // Arrange
            var mockApiService = new Mock<IAPIServices>();
            mockApiService
                .Setup(api => api.GetFuelCombustionEmissionsAsync("Bituminous Coal", 1, "short_ton"))
                .ReturnsAsync(2236.80);

            var calculator = new FuelCalculator(mockApiService.Object, "Bituminous Coal", 1, "short_ton");

            // Act
            var result = await calculator.CalculateEmissionsAsync();

            // Asser
            Assert.AreEqual(2236.80, result, "The calculated emissions for fuel combustion should match the expected value.");
        }

        [TestMethod]
        public async Task ShippingCalculator_ShouldReturnCorrectEmissions()
        {
            // Arrange
            var mockApiService = new Mock<IAPIServices>();
            mockApiService
                .Setup(api => api.GetShippingEmissionsAsync(1000, "g", 1000, "mi", "ship"))
                .ReturnsAsync(0.01);

            var calculator = new ShippingCalculator(mockApiService.Object, 1000, 1000, "ship", "g", "mi");

            // Act
            var result = await calculator.CalculateEmissionsAsync();

            // Assert
            Assert.AreEqual(0.01, result, "The calculated emissions for shipping should match the expected value.");
        }
    }
}
