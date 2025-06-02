using Microsoft.EntityFrameworkCore;
namespace CodeFirst.Models
{
    public class ProjectManageDbContext : DbContext
    {
        public ProjectManageDbContext()
        {

        }
        public ProjectManageDbContext(DbContextOptions<ProjectManageDbContext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}
