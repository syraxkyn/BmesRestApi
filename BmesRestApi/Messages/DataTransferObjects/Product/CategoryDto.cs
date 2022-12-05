using BmesRestApi.Models.Product;

namespace BmesRestApi.Messages.DataTransferObjects.Product
{
    public class CategoryDto
    {
        public String Name { get; set; }
        public string Slug { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public long Id { get; set; }
    }
}
