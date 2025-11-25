using Microsoft.AspNetCore.Mvc;

namespace DemoMVC148.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}