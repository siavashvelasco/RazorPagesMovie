using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor.Data;
using razor.Model;

namespace razor.Pages.Categories
{
	public class IndexModel : PageModel
	{
		public RazorDbContext _db;
		public List<Category> CategoryList { get; set; }
		public IndexModel(RazorDbContext db)
		{
			_db = db;
		}
		public void OnGet()
		{
			CategoryList = _db.Categories.ToList();
		}

	}
}
