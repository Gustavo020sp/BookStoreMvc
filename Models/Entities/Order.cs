using Book_Store.Models.Enums;

namespace Book_Store.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CostumerId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; } 
        public OrderStatus Status { get; set; } 
        public Order() { }
        public Order(int id, double totalPrice, DateTime date, OrderStatus status)
        {
            Id = id;
            TotalPrice = totalPrice;
            Date = date;
            Status = status;
        }
    }
}