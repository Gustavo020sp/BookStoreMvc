namespace Book_Store.Models.Entities
{
	public class CostumerUser : User
	{
		public CostumerUser()
		{
		}

		public CostumerUser(int userid, string name, string email, string password) : base(userid, name, email, password)
		{
		}
	}
}
