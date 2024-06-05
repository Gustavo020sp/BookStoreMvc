namespace Book_Store.Models.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }
        public string? Name { get; set; }


		//Empty constructor to Seed database
		public Category()
		{
		}
		public Category(int categoryid, string? name)
		{
			CategoryId = categoryid;
			Name = name;
		}
	}
}
