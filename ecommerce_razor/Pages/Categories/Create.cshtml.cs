using ecommerce_razor.Data;
using ecommerce_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ecommerce_razor.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category Category { get; set; }

        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(Category category)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            await _db.Category.AddAsync(category);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
