using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stark.BL.Models;
using Stark.BL.Repository;

namespace Stark.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();

            Product expected = new Product(2)
            {
                ProductName = "Mark_2",
                Description = "Second version of Iron man suit",
                CurrentPrice = 15.96M
            };

            // Act
            Product actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod()]
        public void SaveTestValid()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductName = "Bat mobile",
                Description = "Best vehicle in the world.",
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(true, actual);
        }
        
        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "Assorted size set of 4 bright yellow mini sunflowers.",
                ProductName = "Sunflowers",
                HasChanges = true,
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
