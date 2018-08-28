using System;
using Xunit;
using AC.MAIN;

namespace AC.UnitTests
{
    public class GeneralOOPTests
    {
        [Fact]
        public void newGeneralObjectTest1()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Billy";
            c1.LastName = "Jones";
            // Act
            var c2 = c1;
            c2.FirstName = "Jonathan";
            //Assert
            Assert.Equal(c1.FirstName, c2.FirstName);
        }
        [Fact]
        public void newGeneralObjectTest2()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Billy";
            c1.LastName = "Jones";
            // Act
            var c2 = c1;
            c2.FirstName = "Jonathan";
            //Assert
            Assert.Equal(c1.LastName, c2.LastName);
        }
        [Fact]
        public void newGeneralIntTest()
        {
            // Arrange
            int i1 = 42;
            
            // Act
            var i2 = i1;
            i2 = 2;
            //Assert
            Assert.Equal(2, i2);
        }
    }
}