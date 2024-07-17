using System.ComponentModel.DataAnnotations;

namespace BookMvc.Models.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureURL { get; set; }
        public int FullName { get; set; }
        public int Bio { get; set; }

        //Relationships
        public List<Author_Book>? Authors_Books { get; set;}

    }
}
