using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor.Data;
using razor.Model;

namespace razor.Pages.Categories
{
	public class EditModel : PageModel
	{
		public RazorDbContext _db;
		[BindProperty]

		public Category Category { get; set; }



		public EditModel(RazorDbContext db)
		{
			_db = db;
		}


		public void OnGet(int id)
		{

			Category = _db.Categories.Find(id);

		}
		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{
				_db.Categories.Update(Category);
				_db.SaveChanges();
				TempData["Updated"] = "update was ok";
				return RedirectToPage("Index");
			}
			return Page();

		}
	}
}
