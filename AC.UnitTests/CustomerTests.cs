using System;
using Xunit;
using AC.Main;

namespace AC.UnitTests
{
    // Arrange
    // Act
    // Assert

    public class CustomerTests
    {
        [Fact]
        public void newCustomerFirstAndLastNameTest()
        {
            string testFirstName = "Tadas";
            string testLastName = "Tadauskas";
            string testFullName = testLastName + ", " + testFirstName;
            // Arrange
            var customer = new Customer()
            {
                FirstName = testFirstName,
                LastName = testLastName
            };
            // Act
            var fullName = customer.fullName;
            // Assert
            Assert.Equal(testFullName, fullName);
        }
        [Fact]
        public void newCustomerFirstNameTest()
        {
            string testFirstName = "Tadas";
            string testFullName = testFirstName;
            // Arrange
            var customer = new Customer()
            {
                FirstName = testFirstName
            };
            // Act
            var fullName = customer.fullName;
            // Assert
            Assert.Equal(testFullName, fullName);
        }
        [Fact]
        public void newCustomerLastNameTest()
        {
            string testLastName = "Tadauskas";
            string testFullName = testLastName;
            // Arrange
            var customer = new Customer()
            {
                LastName = testLastName
            };
            // Act
            var fullName = customer.fullName;
            // Assert
            Assert.Equal(testFullName, fullName);
        }
        [Fact]
        public void newCustomerCounterTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "James";
            Customer.CustomerCounter += 1;
            var c2 = new Customer();
            c2.FirstName = "Totally not James";
            Customer.CustomerCounter += 1;
            var c3 = new Customer();
            c3.FirstName = "Slim Shady";
            Customer.CustomerCounter += 1;
            // Act
            var count = Customer.CustomerCounter;
            // Assert
            Assert.Equal(3, count);
        }
        [Fact]
        public void validateMissingLastName()
        {
            // Arrange
            var customer = new Customer()
            {
                Email = "james@company.com"
            };
            // Act
            var isValid = customer.Validate();
            // Assert
            Assert.False(isValid);
        }
        [Fact]
        public void validateMissingEmail()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Cameron"
            };
            // Act
            var isValid = customer.Validate();
            // Assert
            Assert.False(isValid);
        }
        [Fact]
        public void validateValid()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Cameron",
                Email = "james@company.com"
            };
            // Act
            var isValid = customer.Validate();
            // Assert
            Assert.True(isValid);
        }

    }
}
