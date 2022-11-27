using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Brand
{
    public class GetCategoryResponse:ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
