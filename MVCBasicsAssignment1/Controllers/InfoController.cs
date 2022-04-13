using Microsoft.AspNetCore.Mvc;
using MVCBasicsAssignment1.Models;
namespace MVCBasicsAssignment1.Controllers
{
    public class InfoController : Controller
    {
        InfoService _infoService;

        public InfoController()
        {
            _infoService = new InfoService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Info = _infoService;
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            ViewBag.About = _infoService.GetAbout();
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            ViewBag.Contact = _infoService.GetContact();
            return View();
        }
        [HttpGet]
        public IActionResult GitHubLinks()
        {
            ViewBag.GitHubLinks = _infoService.GetGitHubLinks();
            return View();
        }


    }
} 
