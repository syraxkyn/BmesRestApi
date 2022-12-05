using BmesRestApi.Models.Product;

namespace BmesRestApi.Messages.DataTransferObjects.Product
{
    public class BrandDto
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public string Slug { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
