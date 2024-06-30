using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // Called: action method -> to handle http requests
        {
            return View();
        }
        public string Error() // Action Method
        {
            return "Error";
        }
    }
}
