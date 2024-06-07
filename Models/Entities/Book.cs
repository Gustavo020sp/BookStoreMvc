namespace Book_Store.Models.Entities
{
    public class Book
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Author { get; set; }
		public string? Description { get; set; }
		public double Price { get; set; }
        public int Stock { get; set; }
        public Category Category { get; set; }

		//image remaining

		public Book() { }
		public Book(int id, string? title, string? author, string? description, double price, int stock, Category category)
		{
			Id = id; 
			Title = title;
			Author = author;
			Description = description;
			Price = price;
			Stock = stock;
			Category = category;
		}
	}
}
