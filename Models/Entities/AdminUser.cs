namespace Book_Store.Models.Entities
{
	public class AdminUser : User
	{
		public string Role { get; set; }

		public AdminUser()
		{
		}

		public AdminUser(int userid, string? username, string? password, string? email, string role) : base(userid, username, password, email)
		{
			Role = role;
		}
	}
}
