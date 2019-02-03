using System.Collections.Generic;
using Acme.CMS.Entities;

namespace Acme.CMS.Repositories
{
    /// <summary>
    /// Repository for Products.
    /// </summary>
    public class ProductRepository
    {
        /// <summary>
        /// Save the product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // setting true for testing
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
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
        /// Retrieve one product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // for testing
            Product product = new Product(productId);
            if (productId != 2) return product;

            product.ProductName = "Sunflowers";
            product.ProductDescription = "Assorted sizes.";
            product.CurrentPrice = 15.96M;
            return product;
        }

        /// <summary>
        /// Retrieve all products.
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            // for testing
            return new List<Product>()
            {
                new Product(123),
                new Product(456),
                new Product(789)
            };
        }
    }
}
