using BookMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BookMvc.Models.Entities
{
    public class Book
    {
        [Key]
        public int Id{ get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }

        //Relationships
        public List<Author_Book>? Books_Authors { get; set;}

    }
}
