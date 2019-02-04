using System;
using System.Collections.Generic;
using Acme.Common;

namespace Acme.BL.Entities
{
    /// <summary>
    /// Order entity.
    /// </summary>
    public class Order : EntityBase, ILoggable
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="orderId"></param>
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        // Note: composition 'has-a' using ObjectId reference.

        /// <summary>
        /// CustomerId of customer associated with the order.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Shipping address for the order.
        /// </summary>
        public int ShippingAddressId { get; set; }

        /// <summary>
        /// Order Id.
        /// </summary>
        public int OrderId { get; private set; }

        // Note: composition i.e. has-a by containing the entire object.
        /// <summary>
        /// OrderItems associated with the order.
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// Order date.
        /// </summary>
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Validate that required properties are set.
        /// </summary>
        /// <returns></returns>
        public override bool Validate() => OrderDate != null;

        ///  <inheritdoc />
        public override string ToString() => $"OrderId:{OrderId}, OrderDate:{OrderDate}";

        /// <summary>
        /// Return a log entry.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string Log(string message)
        {
            return $"{message}:: Id:{OrderId} OrderDate:{OrderDate.ToString()}";
        }
    }
}
    