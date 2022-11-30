using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Request.Product
{
    public class UpdateProductRequest
    {
        public long Id { get; set; }
        public ProductDto Product { get; set; }
    }
}
