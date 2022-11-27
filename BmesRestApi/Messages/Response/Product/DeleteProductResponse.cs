using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Brand
{
    public class DeleteProductResponse:ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
