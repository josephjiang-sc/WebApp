using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index() // Action Method
        {
            return "Hello from Action Method";
        }
        public string Error() // Action Method
        {
            return "Error";
        }
    }
}
