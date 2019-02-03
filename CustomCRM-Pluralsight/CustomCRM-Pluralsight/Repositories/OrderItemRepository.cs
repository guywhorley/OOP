using System.Collections.Generic;
using Acme.CMS.Entities;

namespace Acme.CMS.Repositories
{
    /// <summary>
    /// Repository for order items.
    /// </summary>
    public class OrderItemRepository
    {
        /// <summary>
        /// Save the order item.
        /// </summary>
        /// <returns></returns>
        public bool Save(OrderItem orderItem)
        {
            // setting true for testing
            var success = true;

            if (orderItem.HasChanges && orderItem.IsValid)
            {
                if (orderItem.IsNew)
                {
                    // call an insert operation
                }
                else
                {
                    // call an update operation
                }
            }
            return success;
        }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            // for testing
            OrderItem orderItem = new OrderItem(orderItemId);
            if (orderItemId == 1)
            {
                orderItem.OrderQuantity = 3;
                orderItem.ProductId = 888;
                orderItem.PurchasePrice = 9.99M;
            }
            return orderItem;
        }

        /// <summary>
        /// Retrieve all order items.
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {
            // for testing
            return new List<OrderItem>()
            {
                new OrderItem(123),
                new OrderItem(456),
                new OrderItem(789)
            };
        }
    }
}