namespace Book_Store.Models.Entities
{
	public class AdminUser 
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
        public AdminUser() { }
        public AdminUser(int id, string userName, string password, string email)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Email = email;
        }
    }
}
