using BmesRestApi.Models.Product;

namespace BmesRestApi.Messages.DataTransferObjects.Product
{
    public class ProductDto
    {
        public long Id { get; set; }    
        public String Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string SKU { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int SalePrice { get; set; }
        public int OldPrice { get; set; }
        public string ImageUrl { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsBestseller { get; set; }
        public bool IsFeatured { get; set; }
        public long CategoryId { get; set; }
        public long BrandId { get; set; }
        public int ProductStatus { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
