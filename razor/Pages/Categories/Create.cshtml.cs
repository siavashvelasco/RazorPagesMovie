using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor.Data;
using razor.Model;

namespace razor.Pages.Categories
{
	public class CreateModel : PageModel
	{


		public RazorDbContext _db;
		[BindProperty]
		public Category Category { get; set; }
		public CreateModel(RazorDbContext db)
		{
			_db = db;
		}
		public void OnGet()
		{
		}
		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{
				_db.Categories.Add(Category);
				_db.SaveChanges();
				TempData["Created"] = "Create was ok";
				return RedirectToPage("index");
			}
			return Page();
		}

	}
}
