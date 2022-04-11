using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public class Order
    {
        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTime OrderDate { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
