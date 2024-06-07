namespace Book_Store.Models.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int id, int orderId, int bookId, int quantity, double unitPrice)
        {
            Id = id;
            OrderId = orderId;
            BookId = bookId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
