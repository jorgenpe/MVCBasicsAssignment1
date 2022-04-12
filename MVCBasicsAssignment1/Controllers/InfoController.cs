using Microsoft.AspNetCore.Mvc;

namespace MVCBasicsAssignment1.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
