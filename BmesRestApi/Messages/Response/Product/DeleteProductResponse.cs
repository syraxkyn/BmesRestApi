using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Product
{
    public class DeleteProductResponse:ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
