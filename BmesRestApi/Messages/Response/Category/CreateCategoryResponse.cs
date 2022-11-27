using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Brand
{
    public class CreateCategoryResponse:ResponseBase 
    {
        public CategoryDto Category { get; set; }
    }
}
