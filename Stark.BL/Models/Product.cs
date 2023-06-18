using Stark.Common;

namespace Stark.BL.Models
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        private string productName;
        public string ProductName
        {
            get
            {
                //var stringHandler = new StringHandler();
                //return StringHandler.InsertSpaces(productName);
                return productName.InsertSpaces();
            }
            set { productName = value; }
        }

        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public string Log() => $"{ProductId}: {ProductName} Detail: {Description} Status: {EntityState}";

        public override string ToString()
        {
            return ProductName;
        }

        public override bool Validate()
        {
            bool isValid = string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null ? false : true;
            return isValid;
        }
    }
}
