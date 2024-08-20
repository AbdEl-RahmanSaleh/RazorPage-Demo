using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageDemo.Model;
using RazorPageDemo.Services;

namespace RazorPageDemo.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly IStudentService _studentService;
        private readonly IDepartmentService _departmentService;

        public CreateModel(IStudentService studentService, IDepartmentService departmentService)
        {
            _studentService = studentService;
            _departmentService = departmentService;
        }

        [BindProperty]
        public Student Student { get; set; }

        public List<Department> Departments { get; set; }

        public  IActionResult OnGet()
        {
            Departments =  _departmentService.GetAll();
            return Page();
        }

        public IActionResult OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _studentService.Add(Student);
                return RedirectToPage("Index");
            }

            Departments = _departmentService.GetAll();
            return Page();
        }
    }
}
