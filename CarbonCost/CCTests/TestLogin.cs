using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarbonCost;

namespace CCTests
{
    [TestClass]
    public class TestLogin
    {
        [TestMethod]
        public void Login_WithValidCredentials_ReturnsTrue()
        {
            // Arrange
            var homepage = new homepage();
            string username = "validUser";
            string password = "validPassword";

            // Act
            bool result = homepage.Login(username, password);

            // Assert
            Assert.IsTrue(result, "Login should return true for valid credentials.");
        }

        [TestMethod]
        public void Login_WithInvalidCredentials_ReturnsFalse()
        {
            // Arrange
            var homepage = new homepage();
            string username = "invalidUser";
            string password = "wrongPassword";

            // Act
            bool result = homepage.Login(username, password);

            // Assert
            Assert.IsFalse(result, "Login should return false for invalid credentials.");
        }
    }
}
