using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net.Http;
using System.Threading.Tasks;
using CarbonCost;

namespace CarbonCostTest
{
    [TestClass]
    public sealed class TestElectricityCalculator
    {

        [TestMethod]
        public async Task ElectricityCalculator_ShouldReturnCorrectEmissions()
        {
            // Arrange
            var mockApiService = new Mock<APIServices>("dummyApiKey");
            mockApiService
                .Setup(api => api.GetElectricityEmissionsAsync("kwh", 100, "us", null))
                .ReturnsAsync(50.0);

            var calculator = new ElectricityCalculator(mockApiService.Object, "kwh", 100, "us");

            // Act
            var result = await calculator.CalculateEmissionsAsync();

            // Assert
            Assert.AreEqual(50.0, result, "The calculated emissions should match the expected value.");
        }
    }
}
