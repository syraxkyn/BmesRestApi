using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Brand
{
    public class GetProductResponse:ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
