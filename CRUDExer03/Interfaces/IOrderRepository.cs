using System;
using CRUDExer03.Models;

namespace CRUDExer03.Interfaces
{
	public interface IOrderRepository
	{
        IEnumerable<Order> GetOrders();
        Order GetOrderById(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
        IEnumerable<OrderItem> GetOrderItemsByOrderId(int orderId);
        void AddOrderItem(OrderItem orderItem);

    }
}

