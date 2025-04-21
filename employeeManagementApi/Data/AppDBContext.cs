using Microsoft.EntityFrameworkCore;
using employeeManagementApi.Models;

namespace MyApi.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EmployeeData> Employee => Set<EmployeeData>();

        public DbSet<SalaryData> EmployeeSalary => Set<SalaryData>();

        public DbSet<GetAllEmployeesDataWithSalaries> GetAllEmployeesDataWithSalaries => Set<GetAllEmployeesDataWithSalaries>();
        public DbSet<GetEmployeeSalaryDataById> GetEmployeeSalaryDataById => Set<GetEmployeeSalaryDataById>();

        public DbSet<GetDistinctTitlesWithMinMaxSalaries> GetDistinctTitlesWithMinMaxSalaries => Set<GetDistinctTitlesWithMinMaxSalaries>();

        

        public DbSet<GetEmployeesByReportingManager> GetEmployeesByReportingManager => Set<GetEmployeesByReportingManager>();
        public DbSet<GetEmployeesByAge> GetEmployeesByAge => Set<GetEmployeesByAge>();

        //public DbSet<AddEmployee> AddEmployee => Set<AddEmployee>();
        //public DbSet<AddSalaryData> AddSalaryData => Set<AddSalaryData>();     


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetDistinctTitlesWithMinMaxSalaries>().HasNoKey();
            modelBuilder.Entity<AddEmployee>().HasNoKey();
            modelBuilder.Entity<AddSalaryData>().HasNoKey();
        }


    }
}
