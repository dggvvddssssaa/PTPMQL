using Microsoft.EntityFrameworkCore;
using DemoMVC148.Models;

namespace DemoMVC148.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        // Đổi tên DbSet thành People (có thể đổi thành Persons nếu bạn thích)
        public DbSet<Person> Person { get; set; }
    }
}