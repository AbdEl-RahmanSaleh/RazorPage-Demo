using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageDemo.Model;
using RazorPageDemo.Services;

namespace RazorPageDemo.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly IStudentService _studentService;

        public Student student { get; set; }
        public DetailsModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
                return BadRequest();   
            student = _studentService.GetById(id.Value);
            if (student == null)
                return NotFound();
            else
                return Page();
        }
    }
}
