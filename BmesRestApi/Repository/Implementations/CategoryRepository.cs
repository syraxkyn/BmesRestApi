using BmesRestApi.Database;
using BmesRestApi.Models.Product;

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
            var category = _context.Categories.Find(id);
            return category;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = _context.Categories;
            return categories;
        }
        public void SaveCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
