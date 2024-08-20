using RazorPageDemo.Model;

namespace RazorPageDemo.Services
{
    public interface IStudentService
    {
        public List<Student> GetAll();
        public Student GetById(int? id);
        public void Add(Student std);
        public void Update(Student std);
        public void Delete(int? id);
    }
}
