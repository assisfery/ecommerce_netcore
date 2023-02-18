using ecommerce_netcore.Data;
using ecommerce_netcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_netcore.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categoryList = _db.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            var cat = new Category();
            cat.Name = "Cat";
            cat.DisplayOrder = 1;
            cat.UpdatedDateTime = DateTime.Now;
            _db.Categories.Add(cat);
            _db.SaveChanges();

            return View();
        }
    }
}
