using System.ComponentModel.DataAnnotations;

namespace BookMvc.Models.Entities
{
    public class Book
    {
        [Key]
        public int Id{ get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public double Price {  get; set; }

    }
}
