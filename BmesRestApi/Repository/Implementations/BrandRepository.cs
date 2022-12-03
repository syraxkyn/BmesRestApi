using BmesRestApi.Database;
using BmesRestApi.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Repository.Implementations
{
    public class BrandRepository:IBrandRepository
    {
        private BmesDbContext _context;
        public BrandRepository(BmesDbContext context)
        {
            _context=context;
        }

        public Brand FindBrandById(long id)
        {
            var brand = _context.Brands.FromSqlRaw($"FindBrandById {id}").ToList().FirstOrDefault();
            //var brand = _context.Brands.Find(id);
            return brand;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            var brands = _context.Brands.FromSqlRaw("SelectAllBrands").ToList();
            //var brands = _context.Brands;
            return brands;
        }  
        public void SaveBrand(Brand brand)
        {
            _context.Brands.FromSqlRaw($"CreateBrand {brand.Name},{brand.Slug},{brand.Description},{brand.MetaDescription},{brand.MetaKeywords}").ToList().FirstOrDefault();
            //_context.Brands.Add(brand);
            //_context.SaveChanges();
        }
        public void UpdateBrand(Brand brand)
        {
            _context.Brands.Update(brand);
            _context.SaveChanges();
        }
        public void DeleteBrand(Brand brand)
        {
            _context.Brands.Remove(brand);
            _context.SaveChanges();
        }
    }
}
