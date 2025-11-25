using Microsoft.AspNetCore.Mvc;
using DemoMVC148.Models;
using DemoMVC148.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC148.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Student.ToListAsync();
            return View(model);
        }


    }
}
