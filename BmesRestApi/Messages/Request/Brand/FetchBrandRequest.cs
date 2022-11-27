namespace BmesRestApi.Messages.Request.Brand
{
    public class FetchBrandRequest
    {
        public int PageNumber { get; set; }
        public int BrandsPerPage { get; set; }
    }
}
