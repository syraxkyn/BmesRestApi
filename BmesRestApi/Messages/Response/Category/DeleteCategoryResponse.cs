using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Category
{
    public class DeleteCategoryResponse:ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
