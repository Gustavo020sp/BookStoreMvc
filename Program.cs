using Book_Store.Data;
using Book_Store.Services;
using Microsoft.EntityFrameworkCore;

namespace Book_Store
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BookStoreContext>(options =>
                options.UseMySql(builder.Configuration.GetConnectionString("BookStoreContext"), new MySqlServerVersion(new Version()) ?? throw new InvalidOperationException("Connection string 'SalesWebMvcContext' not found.")));

            // Add services to the container.
            //builder.Services.AddScoped<SeedingService>();

            var app = builder.Build();

			////Add the seed method -- sem implementar no Startup.cs
			//SeedDatabase();
			//void SeedDatabase()
			//{
			//	using (var scope = app.Services.CreateScope())
			//	{
			//		var dbInitializer = scope.ServiceProvider.GetRequiredService<SeedingService>();
			//		dbInitializer.Seed(app);
			//	}
			//}


			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
