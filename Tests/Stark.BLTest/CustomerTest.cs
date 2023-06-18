using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stark.BL.Models;
using Stark.BL.Repository;
using System.Collections.Generic;

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

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Potts",
                Email = "potts@stark.com"
            };

            // Act
            
            // Assert
            Assert.AreEqual(true, customer.Validate());

        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            Customer customer = new Customer
            {
                Email = "potts@stark.com"
            };

            // Act

            // Assert
            Assert.AreEqual(false, customer.Validate());
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Pepper",
                LastName = "Potts",
                Email = "pepperpotts@stark.com",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        AddressLine1 = "Bag End",
                        AddressLine2 = "Bagshot Raw",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144",
                    },
                    new Address()
                    {
                        AddressType = 2,
                        AddressLine1 = "Green dragon",
                        City = "ByWater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146",
                    }
                }

            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].AddressLine1, actual.AddressList[i].AddressLine1);
                Assert.AreEqual(expected.AddressList[i].AddressLine2, actual.AddressList[i].AddressLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
