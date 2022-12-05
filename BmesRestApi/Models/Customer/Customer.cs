
using BmesRestApi.Models.Shared;

namespace BmesRestApi.Models.Customer
{
    using Shared;
    using Order;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Customer:BaseObject
    {
        public long PersonId { get; set; }
        [NotMapped]
        public Person Person { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
