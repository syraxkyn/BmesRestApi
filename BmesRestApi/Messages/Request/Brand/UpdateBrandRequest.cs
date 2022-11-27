using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Request.Brand
{
    public class UpdateBrandRequest
    {
        public long Id { get; set; }
        public BrandDto Brand { get; set; }
    }
}
