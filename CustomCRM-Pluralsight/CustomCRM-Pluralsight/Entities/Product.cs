﻿using System;
using static Acme.Common.StringHandler;

namespace Acme.BL.Entities
{
    /// <summary>
    /// Product entity.
    /// </summary>
    public class Product : EntityBase
    {
        private string _productName;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="productId"></param>
        public Product(int productId)
        {
            ProductId = productId;
        }

        /// <summary>
        /// Product price.
        /// </summary>
        public Decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Product Id.
        /// </summary>
        public int ProductId { get; private set; }

        /// <summary>
        /// Product description.
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        public string ProductName
        {
            get =>  InsertSpaces(_productName);
            set => _productName = value;
        }

        /// <summary>
        /// Validate required properties.
        /// </summary>
        /// <returns></returns>
        public override bool Validate() => !string.IsNullOrWhiteSpace(ProductName) && CurrentPrice != null;

        public override string ToString() => $"Id:{ProductId}, Name:{ProductName}, Price:{CurrentPrice}";
    }
}