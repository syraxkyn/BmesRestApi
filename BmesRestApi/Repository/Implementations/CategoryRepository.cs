using BmesRestApi.Database;
using BmesRestApi.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Repository.Implementations
{
    public class CategoryRepository:ICategoryRepository
    {
        private BmesDbContext _context;
        public CategoryRepository(BmesDbContext context)
        {
            _context=context;
        }

        public Category FindCategoryById(long id)
        {
            var category = _context.Categories.FromSqlRaw($"p_categories_selectById {id}").ToList().FirstOrDefault();
            return category;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = _context.Categories.FromSqlRaw("p_categories_select").ToList();
            return categories;
        }
        public void SaveCategory(Category category)
        {
            if (category != null)
            {
                _context.Brands.FromSqlRaw($"p_categories_insert {category.Name}, {category.Slug}").ToList().FirstOrDefault();
            }
            //_context.Categories.Add(category);
            //_context.SaveChanges();
        }
        public void UpdateCategory(Category category)
        {
            if (category != null)
            {
                _context.Categories.FromSqlRaw($"p_categories_update {category.Id}, {category.Name},{category.Slug}").ToList().FirstOrDefault();
                _context.SaveChanges();
            }
        }
        public void DeleteCategory(Category category)
        {
            if (category != null)
            {
                _context.Categories.FromSqlRaw($"p_categories_delete {category.Id}").ToList().FirstOrDefault();
            }
            //_context.Categories.Remove(category);
            //_context.SaveChanges();
        }
    }
}
