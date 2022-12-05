using BmesRestApi.Models.Shared;

namespace BmesRestApi.Models.Product
{
    public class Category:BaseObject
    {
        public String Name { get; set; }
        public string Slug { get; set; }
    }
}
