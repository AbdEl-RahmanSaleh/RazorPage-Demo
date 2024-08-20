using Microsoft.EntityFrameworkCore;

namespace RazorPageDemo.Model.ApplicationDbContext
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=ITISystemRP;Integrated security=sspi;trustservercertificate=true;encrypt=true");

        }

        
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
