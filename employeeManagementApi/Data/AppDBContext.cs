using Microsoft.EntityFrameworkCore;
using employeeManagementApi.Models;

namespace MyApi.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EmployeeData> Employee => Set<EmployeeData>();

        public DbSet<EmployeeSalaryData> EmployeeSalary => Set<EmployeeSalaryData>();
    }
}
