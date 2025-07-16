using Microsoft.EntityFrameworkCore;

namespace FinalProject.ASP.NETcoreMVC.Models
{
    public class EmployeeDBContext : DbContext
    {
       public DbSet<Employee> Employees { get; set; }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
            
        }
    }
}
