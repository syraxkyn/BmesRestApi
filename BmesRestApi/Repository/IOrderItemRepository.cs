﻿using System.Collections.Generic;
using BmesRestApi.Models.Order;

namespace BmesRestApi.Repositories
{
    public interface IOrderItemRepository
    {
        OrderItem FindOrderItemById(long id);
        IEnumerable<OrderItem> FindOrderItemByOrderId(long orderId);
        IEnumerable<OrderItem> GetAllOrderItems();
        void SaveOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(OrderItem orderItem);
    }
}
