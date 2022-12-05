using BmesRestApi.Database;
using BmesRestApi.Models.Cart;
using BmesRestApi.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Repository.Implementations
{
    public class CartRepository:ICartRepository
    {
        private BmesDbContext _context;
        public CartRepository(BmesDbContext context)
        {
            _context=context;
        }

        public Cart FindCartById(long id)
        {
            var cart = _context.Carts.Find(id);
            return cart;
        }

        public IEnumerable<Cart> GetAllCarts()
        {
            var carts = _context.Carts.FromSqlRaw("p_carts_select").ToList();
            return carts;
        }
        public void SaveCart(Cart cart)
        {
            _context.Carts.FromSqlRaw($"p_carts_insert '{cart.UniqueCartId}', 0").ToList().FirstOrDefault();
            //_context.Carts.Add(cart);
            //_context.SaveChanges();
        }
        public void UpdateCart(Cart cart)
        {
            _context.Carts.Update(cart);
            _context.SaveChanges();
        }
        public void DeleteCart(Cart cart)
        {
            _context.Carts.Remove(cart);
            _context.SaveChanges();
        }
    }
}
