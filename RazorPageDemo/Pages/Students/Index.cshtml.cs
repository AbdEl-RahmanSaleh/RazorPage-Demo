using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageDemo.Model;
using RazorPageDemo.Services;

namespace RazorPageDemo.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly IStudentService _studentService;
        public List<Student> students { get; set; }
        public IndexModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public void OnGet()
        {
            students = _studentService.GetAll();
        }
    }
}
