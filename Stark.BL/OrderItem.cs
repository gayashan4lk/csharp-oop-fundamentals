using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemIt = orderItemId;
        }

        public int OrderItemIt { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Validate()
        {
            bool isValid = (Quantity <= 0 || ProductId <= 0 || PurchasePrice == null) ? false : true;
            return isValid;
        }

        public bool Save()
        {
            return true;
        }

    }
}
