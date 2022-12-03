
using BmesRestApi.Models.Shared;

namespace BmesRestApi.Models.Customer
{
    using Shared;
    using Order;
    public class Customer:BaseObject
    {
        public long PersonId { get; set; }
        public Person Person { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
