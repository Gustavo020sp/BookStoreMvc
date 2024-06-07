using Microsoft.EntityFrameworkCore;

namespace Book_Store.Data
{
	public class BookStoreContext : DbContext
	{
		public BookStoreContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Book_Store.Models.Entities.Book> Book { get; set; }
		public DbSet<Book_Store.Models.Entities.Order> Order { get; set; }
        public DbSet<Book_Store.Models.Entities.OrderItem> OrderItem { get; set; }
        public DbSet<Book_Store.Models.Entities.Costumer> Costumer { get; set; }
		public DbSet<Book_Store.Models.Entities.AdminUser> AdminUser { get; set; }
		public DbSet<Book_Store.Models.Entities.Category> Category { get; set; }

	}
}
