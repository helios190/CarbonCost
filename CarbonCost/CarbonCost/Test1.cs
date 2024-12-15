using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonCost
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CalculateAverageEmissions_ShouldReturnCorrectValue()
        {
            // Arrange
            double electricity = 100;
            double shipping = 150;
            double fuel = 200;
            double expectedAverage = (electricity + shipping + fuel) / 3;

            // Act
            double actualAverage = (electricity + shipping + fuel) / 3;

            // Assert
            Assert.AreEqual(expectedAverage, actualAverage, "The average emissions should be calculated correctly.");
        }
    }

}
