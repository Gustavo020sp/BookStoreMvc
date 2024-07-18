using System.ComponentModel.DataAnnotations;

namespace BookMvc.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string? ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Author_Book>? Authors_Books { get; set;}

        public Author(int id, string? profilePictureURL, string fullName, string bio)
        {
            Id = id;
            ProfilePictureURL = profilePictureURL;
            FullName = fullName;
            Bio = bio;
        }
    }
}
