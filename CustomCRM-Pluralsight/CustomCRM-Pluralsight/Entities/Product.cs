using System;

namespace Acme.CMS.Entities
{
    /// <summary>
    /// Product entity.
    /// </summary>
    public class Product
    {
        // TODO: Add Unit Tests

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Create product with given productId.
        /// </summary>
        /// <param name="productId"></param>
        public Product(int productId)
        {
            this.ProductId = productId;
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
        public string ProductName { get; set; }

        /// <summary>
        /// Validate required properties.
        /// </summary>
        /// <returns></returns>
        public bool Validate() => !string.IsNullOrWhiteSpace(ProductName) && CurrentPrice != null;
    }
}