using Book_Store.Data;
using Book_Store.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Book_Store.Services
{
    public class SeedingService
    {
        private readonly BookStoreContext Context;

        public SeedingService(BookStoreContext _context)
        {
            Context = _context;
        }
        public void Seed(IApplicationBuilder applicationBuilder)
        {
            Seed(applicationBuilder, Context);
        }

        public void Seed(IApplicationBuilder applicationBuilder, BookStoreContext context)
        {
            if (Context.Category.Any() || Context.Book.Any())
            {
                return;
            }

            //Seeding category table in database

            Category Fantasy = new Category { Name = "Fantasy" };
            Category Thriller = new Category { Name = "Thriller" };
            Category Romance = new Category { Name = "Romance" };
            Category Horror = new Category { Name = "Horror" };
            Category ScienceFiction = new Category { Name = "Science Fiction" };



            //Seeding book table in database

            Book b1 = new Book
            {
                Title = "The Hunger Games",
                Author = "Suzanne Collins",
                Description = "Could you survive on your own in the wild, with every one out to make sure you don't live to see the morning?\r\n",
                Price = 90,
                Category = Fantasy,
                ImagePath = "wwwroot\\Images\\hungergames.jpg"
            };
            Book b2 = new Book
            {
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Description = "Since its immediate success in 1813, Pride and Prejudice has remained one of the most popular novels in the English language.",
                Price = 20,
                Category = Romance,
                ImagePath = "wwwroot\\Images\\prideandperju.jpg"
            };
            Book b3 = new Book
            {
                Title = "Escape Velocity",
                Author = "Victor Monibo",
                Description = "Space Habitat Altaire is the premier luxury resort in low Earth orbit, playground of the privileged and the perfect location to host reunions for the Rochford Institute. ",
                Price = 5,
                Category = ScienceFiction,
                ImagePath = "wwwroot\\Images\\escapevelocity.jpg"
            };
            Book b4 = new Book
            {
                Title = "The Red Grove",
                Author = "Tessa Fontaine",
                Description = "When her mother goes missing, a young woman uncovers the secrets beneath her protected community.",
                Price = 15,
                Category = Horror,
                ImagePath = "wwwroot\\Images\\redgrove.jpg"
            };

            //Saving to database
            if (Context is not null)
            {
                Context.Category.AddRange(Fantasy, Thriller, Romance, Horror, ScienceFiction);
                Context.Book.AddRange(b1, b2, b3, b4);
                Context.SaveChanges();
            }

        }
    }
}
