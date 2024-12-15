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
    }
}
