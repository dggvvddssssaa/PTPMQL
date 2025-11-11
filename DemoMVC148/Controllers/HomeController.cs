using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoMVC148.Controllers
{
    public class HomeController : Controller
    {
        // Trang nhập thông tin
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Nhận dữ liệu từ form (tên + năm sinh)
        [HttpPost]
        public IActionResult Index(string tenNguoiDung, int namSinh)
        {
            int tuoi = DateTime.Now.Year - namSinh;
            ViewBag.ThongBao = $"Xin chào {tenNguoiDung}, bạn {tuoi} tuổi.";
            return View();
        }

        // Giải phương trình bậc 2
        [HttpGet]
        public IActionResult GiaiPTB2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GiaiPTB2(double a, double b, double c)
        {
            string kq;
            if (a == 0)
            {
                kq = (b == 0) ? "Phương trình vô nghiệm" : $"Phương trình có 1 nghiệm: x = {-c / b}";
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    kq = "Phương trình vô nghiệm";
                else if (delta == 0)
                    kq = $"Phương trình có nghiệm kép x1 = x2 = {-b / (2 * a)}";
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    kq = $"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
                }
            }

            ViewBag.KetQua = kq;
            return View();
        }
    }
}
