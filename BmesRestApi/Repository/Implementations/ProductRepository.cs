using BmesRestApi.Database;
using BmesRestApi.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Repository.Implementations
{
    public class ProductRepository:IProductRepository
    {
        private BmesDbContext _context;
        public ProductRepository(BmesDbContext context)
        {
            _context=context;
        }

        public Product FindProductById(long id)
        {
            var product = _context.Products.FromSqlRaw($"p_products_selectById {id}").ToList().FirstOrDefault();
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            //var products = _context.Products.FromSqlRaw("p_products_select_innerJoin_categories_brands").ToList();
            var products = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand);
            return products;
        }
        public void SaveProduct(Product product)
        {
            //_context.Products.FromSqlRaw($"p_products_insert 'note',2000,14,11,12").ToList().FirstOrDefault();
            _context.Products.FromSqlRaw($"p_products_insert '{product.Title}',{product.Price},{product.QuantityInStock},{product.CategoryId},{product.BrandId}").ToList().FirstOrDefault();
            //_context.Products.Add(product);
            //_context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _context.Products.FromSqlRaw($"p_products_update {product.Id},{product.Title},{product.Price},{product.QuantityInStock},{product.CategoryId},{product.BrandId}").ToList().FirstOrDefault();
            //_context.Products.Update(product);
            //_context.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            _context.Products.FromSqlRaw($"p_products_delete {product.Id}").ToList().FirstOrDefault();
            //_context.Products.Remove(product);
            //_context.SaveChanges();
        }   
    }
}
