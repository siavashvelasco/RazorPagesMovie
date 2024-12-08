using Microsoft.EntityFrameworkCore;
using WebApp.Models.Models;
namespace WebApp.DataAccess.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "first category", DisplayOrder = 1000 },
				new Category { Id = 2, Name = "ceccond category", DisplayOrder = 1001 }
				);

		}
	}
}
