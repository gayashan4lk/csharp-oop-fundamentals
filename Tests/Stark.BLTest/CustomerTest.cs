using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Stark.BL;

namespace Stark.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            /*Customer customer = new Customer();
            customer.FirstName = "Tony";
            customer.LastName = "Stark";*/

            Customer customer = new Customer
            {
                FirstName = "Tony",
                LastName = "Stark"
            };
            string expected = "Stark, Tony";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Stark"
            };
            string expected = "Stark";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Tony"
            };
            string expected = "Tony";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InstancesTest()
        {
            // Arrange
            Customer.InstanceCount = 0;
            Customer ob1 = new Customer();
            Customer.InstanceCount++;
            Customer ob2 = new Customer();
            Customer.InstanceCount++;
            Customer ob3 = new Customer();
            Customer.InstanceCount++;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
