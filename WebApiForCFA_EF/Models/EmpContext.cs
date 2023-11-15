using Microsoft.EntityFrameworkCore;


namespace WebApiForCFA_EF.Models
{
    public class EmpContext:DbContext
    {
        public EmpContext(DbContextOptions options) : base(options) {
        
        }
        DbSet<Employee> Employees{get;set;}

        DbSet<Department> Departments { get;set;}
    }
}
