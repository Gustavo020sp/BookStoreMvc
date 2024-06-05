using Book_Store.Models.Enums;

namespace Book_Store.Models.Entities
{
	public class Order
	{
		public int OrderId { get; set; }
		public User? User { get; set; }
		public DateTime OrderDate { get; set; }
		public double TotalAmount { get; set; }
		public OrderStatus OrderStatus { get; set; }

		public Order()
		{
		}
		public Order(int orderId, User? user, DateTime orderDate, double totalAmount, OrderStatus orderStatus)
		{
			OrderId = orderId;
			User = user;
			OrderDate = orderDate;
			TotalAmount = totalAmount;
			OrderStatus = orderStatus;
		}
	}
}
