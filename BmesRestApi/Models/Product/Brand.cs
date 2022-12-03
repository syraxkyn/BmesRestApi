using BmesRestApi.Models.Shared;

namespace BmesRestApi.Models.Product
{
    public class Brand:BaseObject
    {
        public String Name { get; set; }
        public string Slug { get; set; }
        public BrandStatus BrandStatus { get; set; }
    }
}
