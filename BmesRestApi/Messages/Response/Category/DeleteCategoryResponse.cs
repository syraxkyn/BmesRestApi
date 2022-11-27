using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Brand
{
    public class DeleteCategoryResponse:ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
