using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor.Data;
using razor.Model;

namespace razor.Pages.Categories
{
	public class DeleteModel : PageModel
	{
		public RazorDbContext _db;
		[BindProperty]
		public Category Category { get; set; }

		public DeleteModel(RazorDbContext db)
		{
			_db = db;

		}
		public void OnGet(int id)
		{
			Category = _db.Categories.Find(id);
		}

		public IActionResult OnPost()
		{
			var obj = _db.Categories.Find(Category.Id);
			if (obj != null)
			{
				_db.Categories.Remove(obj);
				_db.SaveChanges();
				TempData["Deleted"] = "Detet was ok";
				return RedirectToPage("index");
			}
			else { return NotFound(); }
		}
	}
}
