using Microsoft.AspNetCore.Mvc;

namespace DemoMVC148.Controllers
{
    public class DemoController : Controller
    {
        // Action 1: ViewResult
        public IActionResult Index()
        {
            ViewBag.Message = "Buổi học số 3 - Ví dụ về các loại Result trong ASP.NET MVC";
            return View();
        }

        // Action 2: RedirectResult
        public IActionResult GoToGoogle()
        {
            return Redirect("https://www.google.com");
        }

        // Action 3: RedirectToActionResult
        public IActionResult RedirectToDemo()
        {
            return RedirectToAction("Index");
        }

        // Action 4: JsonResult
        public IActionResult GetJson()
        {
            var data = new
            {
                Name = "Đinh minh Phương",
                Subject = "ASP.NET MVC",
                Lesson = 3
            };
            return Json(data);
        }

        // Action 5: FileResult
        public IActionResult DownloadFile()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "sample.txt");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/plain", "sample.txt");
        }

        // Action 6: StatusCodeResult
        public IActionResult ErrorPage()
        {
            return StatusCode(404, "Trang bạn yêu cầu không tồn tại!");
        }
    }
}
