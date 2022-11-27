using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Request.Brand
{
    public class UpdateCategoryRequest
    {
        public long Id { get; set; }
        public CategoryDto Category { get; set; }
    }
}
