namespace Book_Store.Models.Entities
{
    public class Costumer
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }

        public Costumer() { }
        public Costumer(int id, string? username, string? password, string? email)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
