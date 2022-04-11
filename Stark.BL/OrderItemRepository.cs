using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public class OrderItemRepository
    {
        public OrderItem Retrieve(int orderItemId)
        {
            OrderItem item = new OrderItem(orderItemId);

            if(orderItemId == 101)
            {
                item.ProductId = 1;
                item.PurchasePrice = (decimal?)25.25;
                item.Quantity = 5;
            }
            return item;
        }

        public bool Save()
        {
            return true;
        }
    }
}
