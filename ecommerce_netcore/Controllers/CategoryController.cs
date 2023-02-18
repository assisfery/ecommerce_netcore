using ecommerce_netcore.Data;
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
            var categoryList = _db.Categories.ToList();
            //return categoryList;
            return View();
        }
    }
}
