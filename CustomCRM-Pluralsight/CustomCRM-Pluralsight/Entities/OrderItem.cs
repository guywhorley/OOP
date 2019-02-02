namespace Acme.CMS.Entities
{
    /// <summary>
    /// OrderItem entity.
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public OrderItem()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="orderItemId"></param>
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        /// <summary>
        /// OrderItem Id.
        /// </summary>
        public int OrderItemId { get; private set; }

        /// <summary>
        /// Order quantity.
        /// </summary>
        public int OrderQuantity { get; set; }

        /// <summary>
        /// Product Id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Purchase price.
        /// </summary>
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Validate that required properties are set.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return OrderQuantity > 0 &&
                   ProductId > 0 &&
                   PurchasePrice != null;
        }
    }
}