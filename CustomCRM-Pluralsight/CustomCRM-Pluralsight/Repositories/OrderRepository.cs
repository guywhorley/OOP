using System;
using System.Collections.Generic;
using Acme.CMS.Entities;

namespace Acme.CMS.Repositories
{
    /// <summary>
    /// Repository for orders.
    /// </summary>
    public class OrderRepository
    {
        /// <summary>
        /// Save the order.
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order) => true;

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // for testing
            Order order = new Order(orderId);
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset();
            }
            return order;
        }

        /// <summary>
        /// Retrieve all orders.
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            // for testing
            return new List<Order>()
            {
                new Order(123),
                new Order(456),
                new Order(789)
            };
        }
    }
}