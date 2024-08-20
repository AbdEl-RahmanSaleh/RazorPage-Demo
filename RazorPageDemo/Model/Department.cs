using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RazorPageDemo.Model
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(2)]
        public string DeptName { get; set; }
        [Range(15, 40)]
        public int Capacity { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

    }
}
