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
            string expected = "Tony Stark";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
