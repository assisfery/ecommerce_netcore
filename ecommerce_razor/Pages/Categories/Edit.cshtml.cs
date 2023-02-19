using ecommerce_razor.Data;
using ecommerce_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ecommerce_razor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        public Category? Category { get; set; }

        private readonly ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);

            if(Category == null)
            {
                //return NotFound();
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Category.Update(Category);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
