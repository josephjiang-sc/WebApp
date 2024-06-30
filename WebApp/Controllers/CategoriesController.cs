using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit(int? id) // .Net 8 default value of int: 0
        {
            var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
            
            return View(category);
        }
    }
}
