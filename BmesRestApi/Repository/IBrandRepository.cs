using BmesRestApi.Models.Product;

namespace BmesRestApi.Repository
{
    public interface IBrandRepository
    {
        Brand FindBrandById(long id);
        IEnumerable<Brand> GetAllBrands();
        void SaveBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
    }
}
