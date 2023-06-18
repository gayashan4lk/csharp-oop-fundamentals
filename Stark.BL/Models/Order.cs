using Stark.Common;
using System;
using System.Collections.Generic;

namespace Stark.BL.Models
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public string Log() => $"{OrderId}: Date: {OrderDate.Value.Date} Status: {EntityState}";

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

        public override bool Validate()
        {
            bool IsValid = OrderDate == null ? false : true;
            return IsValid;
        }
    }
}
