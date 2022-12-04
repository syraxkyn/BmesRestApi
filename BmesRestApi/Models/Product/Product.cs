using BmesRestApi.Models.Shared;

namespace BmesRestApi.Models.Product
{
    public class Product:BaseObject
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int QuantityInStock { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public long BrandId { get; set; }
        public Brand Brand { get; set; }
        public ProductStatus ProductStatus { get; set; }
    }
}
