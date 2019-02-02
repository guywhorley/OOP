namespace Acme.CMS.Entities
{
    class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int OrderQuantity { get; set; }

        public int ProductId { get; set; }

        public decimal? PurchasePrice { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            // true: orderQuantity > 0, ProductId > 0, PurchasePrice not null
            return true;
        }
    
    }
}
