using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data;
using Npgsql;

namespace CarbonCostTest
{
    public class CompanyRepository
    {

    [TestClass]
    public sealed class TestRepository
    {
        [TestMethod]
        public void UpdateCompanyEmissions_ShouldExecuteWithoutErrors()
        {
            // Arrange
            var mockConnection = new Mock<NpgsqlConnection>("Host=localhost;Port=5432;Username=postgres;Password=Marvel_123;Database=carboncost");
            var mockCommand = new Mock<NpgsqlCommand>();
            var repository = new CompanyRepository("Host=localhost;Port=5432;Username=postgres;Password=Marvel_123;Database=carboncost");

            // Mock connection behavior
            mockConnection.Setup(c => c.Open());
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(1);

            // Act
            repository.UpdateCompanyEmissions(1, 75.0);

            // Assert
            mockConnection.Verify(conn => conn.Open(), Times.Once, "The connection should be opened once.");
            mockCommand.Verify(cmd => cmd.ExecuteNonQuery(), Times.Once, "The query should be executed once.");
        }
    }
}
