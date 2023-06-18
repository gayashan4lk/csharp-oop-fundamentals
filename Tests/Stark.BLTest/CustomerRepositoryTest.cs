using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stark.BL.Models;
using Stark.BL.Repository;

namespace Stark.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expected = new Customer(1)
            {
                Email = "pepperpotts@stark.com",
                FirstName = "Pepper",
                LastName = "Potts"
            };

            // Act
            Customer actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Email, actual.Email);

        }

    }
}
