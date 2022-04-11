using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "Mark_2";
                product.Description = "Second version of Iron man suit";
                product.CurrentPrice = 15.96M;
            }
            return product;
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
