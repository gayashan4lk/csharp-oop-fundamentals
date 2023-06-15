namespace Stark.BL.Models
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public bool Validate()
        {
            bool isValid = Quantity <= 0 || ProductId <= 0 || PurchasePrice == null ? false : true;
            return isValid;
        }
    }
}
