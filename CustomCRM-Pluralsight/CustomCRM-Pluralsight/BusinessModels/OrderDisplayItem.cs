﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CMS.BusinessModels
{
    //TODO: Finish comments
    /// <summary>
    /// A class that contains only the properties required for displaying a single OrderItem.
    /// </summary>
    public class OrderDisplayItem
    {
        public int OrderItemId { get; set; }

        public int OrderQuantity { get; set; }

        public string ProductName { get; set; }

        public decimal? PurchasePrice { get; set; }
    }
}