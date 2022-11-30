using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Request.Category
{
    public class UpdateCategoryRequest
    {
        public long Id { get; set; }
        public CategoryDto Category { get; set; }
    }
}
