namespace Book_Store.Models.Entities
{
	public class OrderItem
	{
        public int OrderItemId { get; set; }
        public Order? Order { get; set; }
		public double UnitPrice { get; set; }
		public double Quantity { get; set; }
		public OrderItem(int orderItemId, Order? order, double unitPrice, double quantity)
		{
			OrderItemId = orderItemId;
			Order = order;
			UnitPrice = unitPrice;
			Quantity = quantity;
		}
	}
}
