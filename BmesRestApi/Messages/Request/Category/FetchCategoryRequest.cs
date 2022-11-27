namespace BmesRestApi.Messages.Request.Brand
{
    public class FetchCategoryRequest
    {
        public int PageNumber { get; set; }
        public int CategoriesPerPage { get; set; }
    }
}
