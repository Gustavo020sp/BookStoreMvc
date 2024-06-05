namespace Book_Store.Models.Entities
{
	public class Book
	{
		public int BookId { get; set; }
		public string? Title { get; set; }
		public string? Author { get; set; }
		public string? Description { get; set; }
		public double Price { get; set; }
		public Category Category { get; set; }

		//image remaining

		public Book()
		{
		}
		public Book(string? title, string? author, string? description, double price, Category category)
		{

			Title = title;
			Author = author;
			Description = description;
			Price = price;
			Category = category;
		}
	}
}
