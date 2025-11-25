using Microsoft.EntityFrameworkCore;
using DemoMVC148.Models;

namespace DemoMVC148.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }

        public DbSet<Student> Student { get; set; }
    }
}