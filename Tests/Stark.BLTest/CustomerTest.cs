﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
