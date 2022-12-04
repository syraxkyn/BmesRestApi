using System;
using System.Collections.Generic;

namespace BmesRestApi.Messages.DataTransferObjects.Order
{
    public class OrderDto
    {
        public long Id { get; set; }
        public int OrderTotal { get; set; }
        public int OrderItemTotal { get; set; }
        public int ShippingCharge { get; set; }
        public long CustomerId { get; set; }
        public int OrderStatus { get; set; }
        public IEnumerable<OrderItemDto> OrderItems { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
