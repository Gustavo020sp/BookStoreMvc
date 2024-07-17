using BookMvc.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookMvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Book>().HasKey(ab => new
            {
                ab.AuthorId,
                ab.BookId,
            });

            modelBuilder.Entity<Author_Book>().HasOne(b => b.Book).WithMany(ba => ba.Books_Authors).HasForeignKey(b => b.BookId);
            modelBuilder.Entity<Author_Book>().HasOne(b => b.Author).WithMany(ba => ba.Authors_Books).HasForeignKey(b => b.AuthorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author_Book> Author_Books { get; set; }
    }
}
