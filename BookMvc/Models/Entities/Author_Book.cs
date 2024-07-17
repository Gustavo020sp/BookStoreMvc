namespace BookMvc.Models.Entities
{

    //This class is created because of Many to Many Relationship
    public class Author_Book
    {
        public int BookId { get; set; }
        public Book? Book { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
