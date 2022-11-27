using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Brand
{
    public class CreateProductResponse:ResponseBase 
    {
        public ProductDto Product { get; set; }
    }
}
