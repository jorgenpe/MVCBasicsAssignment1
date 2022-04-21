using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCBasicsAssignment1.Models;
namespace MVCBasicsAssignment1.Controllers
{
    public class DoctorController : Controller
    {

        FeverUtillity _feverUtillity;

        public DoctorController()
        {
            _feverUtillity = new FeverUtillity();
        }

        public IActionResult Index()
        {
            
            ViewBag.CheckFever = _feverUtillity.GetFever();
            return View();
        }

        [HttpGet]  
        public IActionResult CheckFever()
        {
            ViewBag.CheckFever = _feverUtillity.GetFever();
            return View();
        }

        [HttpDelete]
        public IActionResult DeleteCheckFever()
        {
            ViewData.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CheckFever(string fever)
        {
            try
            {
                _feverUtillity.SetTempature(fever);

                return RedirectToAction("Index"); 

            }catch (ArgumentException exData)
            {
                ViewBag.ExceptionMsg = exData.Message;
            }

            ViewBag.Fever = fever;
            ViewBag.CheckFever = _feverUtillity.GetFever();

            return ViewBag();
        }
    } 
}
