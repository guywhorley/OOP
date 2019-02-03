using System;
using System.Collections.Generic;
using Acme.CMS.Entities;
using Acme.CMS.Views;

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
        public bool Save(Order order)
        {
            // setting true for testing
            var success = true;

            if (order.HasChanges && order.IsValid)
            {
                if (order.IsNew)
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

        /// <summary>
        /// Retrieve OrderDisplay for given orderId.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            // code that retrieves defined order fields

            // for testing - set basic orderDisplay info
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset();
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = AddressType.Work,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }

            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();
            //code that retrieves the order items

            // testing - set orderItem info
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;
        }
    }
}