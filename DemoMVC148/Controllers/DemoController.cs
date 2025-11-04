using Microsoft.AspNetCore.Mvc;
using DemoMVC148.Models;

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
        public IActionResult DataDemo()
        {
            ViewBag.Message = "Xin chào từ ViewBag!";
            ViewData["Note"] = "Đây là dữ liệu từ ViewData.";
            TempData["Temp"] = "Dữ liệu này đến từ TempData (sẽ còn sau redirect).";
            return View();
        }

        public IActionResult TempDataResult()
        {
            // Lấy lại dữ liệu từ TempData (sau khi redirect)
            var tempMessage = TempData["Temp"];
            ViewBag.TempMessage = tempMessage;
            return View();
        }

        public IActionResult RedirectTemp()
        {
            TempData["Temp"] = "Dữ liệu qua redirect thành công!";
            return RedirectToAction("TempDataResult");
        }
        public IActionResult InputDemo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InputDemo(string username, int age)
        {
            ViewBag.Result = $"Xin chào {username}, bạn {age} tuổi!";
            return View();
        }
        // Hiển thị form nhập
        [HttpGet]
        public IActionResult StudentForm()
        {
            return View();
        }

        // Nhận dữ liệu từ form (POST)
        [HttpPost]
        public IActionResult StudentForm(Student student)
        {
            // Gửi dữ liệu qua View hiển thị kết quả
            return View("StudentResult", student);
        }

    }
}
