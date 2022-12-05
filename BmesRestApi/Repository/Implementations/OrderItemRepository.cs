﻿using System.Collections.Generic;
using System.Linq;
using BmesRestApi.Database;
using BmesRestApi.Models.Order;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Repositories.Implementations
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private BmesDbContext _context;

        public OrderItemRepository(BmesDbContext context)
        {
            _context = context;
        }

        public OrderItem FindOrderItemById(long id)
        {
            var orderItem = _context.OrderItems.Find(id);
            return orderItem;
        }

        public IEnumerable<OrderItem> FindOrderItemByOrderId(long orderId)
        {
            var orderItems = _context.OrderItems.Where(o => o.OrderId == orderId);
            return orderItems;
        }

        public IEnumerable<OrderItem> GetAllOrderItems()
        {
            var orderItems = _context.OrderItems;
            return orderItems;
        }

        public void SaveOrderItem(OrderItem orderItem)
        {
            //_context.OrderItems.FromSqlRaw($"p_orderItems_insert '{orderItem.Quantity}',{orderItem.OrderId},{orderItem.ProductId}").ToList().FirstOrDefault();
            _context.OrderItems.Add(orderItem);
            //_context.SaveChanges();
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            _context.OrderItems.Update(orderItem);
        }

        public void DeleteOrderItem(OrderItem orderItem)
        {
            _context.OrderItems.Remove(orderItem);
        }
    }
}
