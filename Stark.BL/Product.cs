using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            bool isValid = (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null) ? false : true;
            return isValid;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }


        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
