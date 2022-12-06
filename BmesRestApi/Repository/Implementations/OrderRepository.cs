using System.Collections.Generic;
using BmesRestApi.Database;
using BmesRestApi.Models.Customer;
using BmesRestApi.Models.Order;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        private BmesDbContext _context;

        public OrderRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Order FindOrderById(long id)
        {
            var order = _context.Orders.Find(id);
            return order;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = _context.Orders;
            return orders;
        }

        public void SaveOrder(Order order)
        {
            _context.Orders.FromSqlRaw($"p_orders_insert '{order.OrderTotal}',{order.OrderItemTotal},{order.ShippingCharge},{order.CustomerId}").ToList().FirstOrDefault();
            //_context.Orders.Add(order);
            //_context.SaveChanges();
        }

        //public int GetLastOrderId()
        //{
        //    Order order = _context.Orders.FromSqlRaw("Select * from Orders where id=(select max(id) from Orders)").ToList().FirstOrDefault();
        //    return (int)order.Id;
        //}
        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}
