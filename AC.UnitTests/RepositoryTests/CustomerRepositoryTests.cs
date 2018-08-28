using System;
using Xunit;
using AC.Repository;
using AC.Main;

namespace AC.UnitTests.RepositoryTests
{
    // Arrange
    // Act
    // Assert
    public class RetrieveExistingCustomer
    {
        [Fact]
        public void CustomerRetrieveTest()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "jamesanderson@gmail.com",
                FirstName = "James",
                LastName = "Anderson"
            };
            // Act
            var actual = customerRepository.Retrieve(1);
            // Assert
            Assert.Equal(expected.CustomerID, actual.CustomerID);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
        }
    }
}