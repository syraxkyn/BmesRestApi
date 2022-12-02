﻿using BmesRestApi.Models.Address;
using BmesRestApi.Models.Shared;

namespace BmesRestApi.Models.Customer
{
    using Shared;
    using Address;
    using Order;
    public class Customer:BaseObject
    {
        public long PersonId { get; set; }
        public Person Person { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
