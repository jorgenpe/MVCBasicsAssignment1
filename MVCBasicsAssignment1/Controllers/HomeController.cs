using Microsoft.AspNetCore.Mvc;

namespace MVCBasicsAssignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
