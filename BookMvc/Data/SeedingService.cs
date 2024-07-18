using BookMvc.Models.Entities;
using System.Collections.Specialized;
using System.Runtime.Intrinsics.X86;

namespace BookMvc.Data
{
    public class SeedingService
    {

        private readonly BookStoreDbContext Context;

        public SeedingService(BookStoreDbContext _context)
        {
            Context = _context;
        }
        public void Seed(IApplicationBuilder applicationBuilder)
        {
            Seed(applicationBuilder, Context);
        }

        public void Seed(IApplicationBuilder applicationBuilder, BookStoreDbContext context)
        {
                        
                if (!context.Books.Any() || !context.Authors.Any() || !context.Author_Book.Any())
                {
                    //Books
                    Book b1 = new Book(1, "Test", "test", "test", Models.Enums.Category.Romance);
                    Book b2 = new Book(2, "Test", "test", "test", Models.Enums.Category.Drama);
                    Book b3 = new Book(3, "Test", "test", "test", Models.Enums.Category.Romance);
                    Book b4 = new Book(4, "Test", "test", "test", Models.Enums.Category.Horror);
                    Book b5 = new Book(5, "Test", "test", "test", Models.Enums.Category.Drama);
                    Book b6 = new Book(6, "Test", "test", "test", Models.Enums.Category.Action);

                    //Authors
                    Author a1 = new Author(1, "imageurl", "name", "bio");
                    Author a2 = new Author(1, "imageurl", "name", "bio");
                    Author a3 = new Author(1, "imageurl", "name", "bio");
                    Author a4 = new Author(1, "imageurl", "name", "bio");
                    Author a5 = new Author(1, "imageurl", "name", "bio");

                    //Author_Book > Join table (?)
                    Author_Book a_b1 = new Author_Book(5, 3);
                    Author_Book a_b2 = new Author_Book(4, 1);
                    Author_Book a_b3 = new Author_Book(2, 3);
                    Author_Book a_b4 = new Author_Book(4, 2);
                    Author_Book a_b5 = new Author_Book(2, 1);

                    context.Books.AddRange(b1, b2, b3, b4, b5, b6);
                    context.Authors.AddRange(a1,a2,a3,a4,a5);
                    context.Author_Book.AddRange(a_b1, a_b2, a_b3, a_b4, a_b5);

                    context.SaveChanges();
                }

            }

        }
    }

