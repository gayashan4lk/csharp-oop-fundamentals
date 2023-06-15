using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stark.BL.Models;
using Stark.Common;
using System.Collections.Generic;

namespace Stark.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                Email = "fbaggins@hobitton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                Description = "Garden rake with steel head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
            // Nothing to assert
        }
    }
}
