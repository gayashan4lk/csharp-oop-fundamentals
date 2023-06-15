using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stark.BL.Models;
using Stark.BL.Repository;
using System;

namespace Stark.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order expected = new Order(101)
            {
                OrderDate = DateTimeOffset.UtcNow
            };

            // Act
            Order actual = orderRepository.Retrieve(101);
            
            // Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
