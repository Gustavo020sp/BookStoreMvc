namespace Book_Store.Models.Entities
{
	public class User
	{
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }

		public User()
		{
		}

		public User(int userid, string? username, string? password, string? email)
		{
			UserId = userid;
			Username = username;
			Password = password;
			Email = email;
		}
	}
}
