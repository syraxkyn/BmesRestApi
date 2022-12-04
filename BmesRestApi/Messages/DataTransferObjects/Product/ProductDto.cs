using BmesRestApi.Models.Product;

namespace BmesRestApi.Messages.DataTransferObjects.Product
{
    public class ProductDto
    {
        public long Id { get; set; }    
        public string Title { get; set; }
        public int Price { get; set; }
        public int QuantityInStock { get; set; }
        public long CategoryId { get; set; }
        public long BrandId { get; set; }
        public int ProductStatus { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
