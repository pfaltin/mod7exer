using System;
using System.Collections.Generic;
using CRUDExer03.Interfaces;
using CRUDExer03.Models;

namespace CRUDExer03.Repositories
{
	public class OrderRepository : IOrderRepository
	{
        private List<Order> _orders; // = new List<Order>();
        private List<OrderItem> _ordersItems;

        public OrderRepository()
		    {
                _orders = new List<Order>();
                
                _ordersItems = new List<OrderItem>();
            }

        public void AddOrder(Order order)
            {
                _orders.Add(order);
            }

        public void AddOrderItem(OrderItem orderItem)
            {
                // get order by order ID
                // Order order = _orders.Find(ord => ord.OrderId == orderItem.OrderId);
                _ordersItems.Add(orderItem);

            }

        public void DeleteOrder(int id)
            {
                OrderItem ItemToremove;
                // delete order items (_ordersItems.Contains(_ordersItems.FirstOrDefault(ordIt => ordIt.OrderId == id)))
                //do
                //{
                //   ItemToremove = _ordersItems.FirstOrDefault(ordIt => ordIt.OrderId == id);
                //    if (ItemToremove != null) 
                //        _ordersItems.Remove(ItemToremove);
                //} while (ItemToremove!= null) ;

                // delete order
                _orders.Remove(_orders.Find(ord => ord.OrderId == id));

            }

        public Order GetOrderById(int id)
            {
                return _orders.Find(ord => ord.OrderId == id);
            }

        public IEnumerable<OrderItem> GetOrderItemsByOrderId(int orderItemId)
            {
                IEnumerable<OrderItem> orderItems = _ordersItems.FindAll(ordIt => ordIt.OrderItemId == orderItemId);
                return orderItems;
            }


        public IEnumerable<Order> GetOrders()
            {
                return _orders;
            }

        public void UpdateOrder(Order order)
            {
                _orders.ForEach(p =>
                {
                    if (p.OrderId == order.OrderId)
                    {
                        p = order;
                    
                    }
                });
            }
    }
}

