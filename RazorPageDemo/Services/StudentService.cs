using Microsoft.EntityFrameworkCore;
using RazorPageDemo.Model;
using RazorPageDemo.Model.ApplicationDbContext;

namespace RazorPageDemo.Services
{
    public class StudentService : IStudentService
    {

        ApplicationContext context = new ApplicationContext();


        public List<Student> GetAll()
            => context.Students.Include(s => s.Department).ToList();

        public Student GetById(int? id)
            => context.Students.Include(s => s.Department).SingleOrDefault(s => s.Id == id);


        public void Add(Student std)
        {
            context.Students.Add(std);
            context.SaveChanges();
        }
        public void Update(Student std)
        {
            context.Students.Update(std);
            context.SaveChanges();
        }
        public void Delete(int? id)
        {
            var std = context.Students.FirstOrDefault(s => s.Id == id);
            context.Students.Remove(std);
            context.SaveChanges();
        }
        
    }
}
