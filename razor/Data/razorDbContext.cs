using Microsoft.EntityFrameworkCore;
using razor.Model;

namespace razor.Data
{
	public class RazorDbContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public RazorDbContext(DbContextOptions<RazorDbContext> options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Ali", DisplayOrder = 100 },
				new Category { Id = 5,Name = "Reza",DisplayOrder=500});
		}
	}
}
