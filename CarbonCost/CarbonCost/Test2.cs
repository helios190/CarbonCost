using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data;

namespace CarbonCost.Tests
{
    [TestClass]
    public class TestRepository
    {
        [TestMethod]
        public void UpdateCompanyEmissions_ShouldExecuteWithoutErrors()
        {
            // Arrange
            var mockFactory = new Mock<IDbConnectionFactory>();
            var mockConnection = new Mock<IDbConnection>();
            var mockCommand = new Mock<IDbCommand>();
            var mockParameterCollection = new Mock<IDataParameterCollection>();

            // Mock connection creation
            mockFactory.Setup(factory => factory.CreateConnection()).Returns(mockConnection.Object);
            mockConnection.Setup(conn => conn.CreateCommand()).Returns(mockCommand.Object);

            // Mock parameters and parameter collection
            mockCommand.Setup(cmd => cmd.CreateParameter()).Returns(new Mock<IDbDataParameter>().Object);
            mockCommand.SetupGet(cmd => cmd.Parameters).Returns(mockParameterCollection.Object);

            // Mock command execution behavior
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(1);

            var repository = new CompanyRepository(mockFactory.Object);

            // Act
            repository.UpdateCompanyEmissions(1, 75.0);

            // Assert
            mockConnection.Verify(conn => conn.Open(), Times.Once, "The connection should be opened once.");
            mockCommand.Verify(cmd => cmd.ExecuteNonQuery(), Times.Once, "The query should be executed once.");
            mockCommand.Verify(cmd => cmd.CreateParameter(), Times.Exactly(2), "CreateParameter should be called twice for two parameters.");
        }
    }
}
