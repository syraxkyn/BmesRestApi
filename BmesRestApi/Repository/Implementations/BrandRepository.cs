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
            var brand = _context.Brands.FromSqlRaw($"p_brands_selectById {id}").ToList().FirstOrDefault();
            //var brand = _context.Brands.Find(id);
            return brand;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            var brands = _context.Brands.FromSqlRaw("p_brands_select").ToList();
            //var brands = _context.Brands;
            return brands;
        }  
        public void SaveBrand(Brand brand)
        {
            _context.Brands.FromSqlRaw($"p_brands_insert {brand.Name}, {brand.Slug}").ToList().FirstOrDefault();
            //_context.Brands.Add(brand);
            //_context.SaveChanges();
        }
        public void UpdateBrand(Brand brand)
        {
            _context.Brands.FromSqlRaw($"p_brands_update {brand.Id}, {brand.Name},{brand.Slug}").ToList().FirstOrDefault();
            //_context.Brands.Update(brand);
            //_context.SaveChanges();
        }
        public void DeleteBrand(Brand brand)
        {
            _context.Brands.FromSqlRaw($"p_brands_delete {brand.Id}").ToList().FirstOrDefault();
        }
    }
}
