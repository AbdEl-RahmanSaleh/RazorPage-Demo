using RazorPageDemo.Model;
using RazorPageDemo.Model.ApplicationDbContext;

namespace RazorPageDemo.Services
{
    public class DepartmentService : IDepartmentService
    {
        ApplicationContext context = new ApplicationContext();


        public List<Department> GetAll()
            => context.Departments.Where(d => d.Active == true).ToList();

        public Department GetById(int? id)
          => context.Departments.SingleOrDefault(d => d.Id == id);


        public void Add(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
        public void Update(Department dept)
        {
            context.Departments.Update(dept);
            context.SaveChanges();
        }
        public void Delete(int? id)
        {
            var dept = context.Departments.FirstOrDefault(d => d.Id == id);
            dept.Active = false;
            //context.Departments.Remove(dept);
            context.SaveChanges();
        }
    }
}
