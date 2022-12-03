using BmesRestApi.Messages.DataTransferObjects.Order;
using System;
using System.Collections.Generic;

namespace BmesRestApi.Messages.DataTransferObjects.Customer
{
    public class CustomerDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public string DateOfBirth { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<OrderDto> Orders { get; set; }
    }
}
