using Microsoft.AspNetCore.Mvc;
using DemoMVC148.Models;

namespace DemoMVC148.Controllers
{
    public class DemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string studentName, int studentAge)
        {
            ViewBag.Message = $"Student Name: {studentName}, Age: {studentAge}";
            return View();
        }


    }
}
