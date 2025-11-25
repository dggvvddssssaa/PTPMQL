using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC148.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string? studentcode { get; set; }
        public int? fullname { get; set; }
        public string? Address { get; set; }
    }
}