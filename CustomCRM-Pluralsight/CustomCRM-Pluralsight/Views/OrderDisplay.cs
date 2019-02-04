using System;
using System.Collections.Generic;
using Acme.BL.Entities;

namespace Acme.BL.Views
{
    //TODO: Finish comments
    /// <summary>
    /// A class containing only the properties required for displaying an order.
    /// </summary>
    public class OrderDisplay
    {
        /// <summary>
        /// Customer first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Customer last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Order date.
        /// </summary>
        public DateTimeOffset? OrderDate { get; set; }

        // Note: Example of composition i.e. has-a.
        /// <summary>
        /// List of order items.
        /// </summary>
        public List<OrderDisplayItem> OrderDisplayItemList { get; set; }

        public int OrderId { get; set; }

        public Address ShippingAddress { get; set; }
    }
}