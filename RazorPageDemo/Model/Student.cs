
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RazorPageDemo.Model
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Student name must be more than 2 character")]
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(20, 30)]
        public int Age { get; set; }
        public string Email { get; set; }

        public string Gender { get; set; }

        [ForeignKey("department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}
