namespace BmesRestApi.Models.Order
{
    using System.Collections.Generic;
    using Shared;
    using Customer;
    public class Order : BaseObject
    {
        public int OrderTotal { get; set; }
        public int OrderItemTotal { get; set; }
        public int ShippingCharge { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
