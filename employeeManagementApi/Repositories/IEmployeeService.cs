using System.Threading.Tasks;
using employeeManagementApi.Models;

namespace employeeManagementApi.Repositories
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeData> GetAllEmployeeData();
        IEnumerable<SalaryData> GetAlSalaryData();
        IEnumerable<GetAllEmployeesDataWithSalaries> GetAllEmployeesDataWithSalaries();
        GetEmployeeSalaryDataById GetEmployeeSalaryDataById(int id);
        IEnumerable<GetDistinctTitlesWithMinMaxSalaries> GetDistinctTitlesWithMinMaxSalaries();
        IEnumerable<GetAllEmployeesDataWithSalaries> GetEmpSalariesByTitle(string title);
        IEnumerable<GetAllEmployeesDataWithSalaries> GetEmployeesSalaryByName(string name);
        IEnumerable<GetEmployeesByReportingManager> GetEmployeesByReportingManager(int id);
        IEnumerable<GetEmployeesByAge> GetEmployeesBelowAnAge(int age);
        IEnumerable<GetEmployeesByAge> GetEmployeesAboveAnAge(int age);
        void AddEmployee(AddEmployee empdata);
        void AddEmployeeSalary(AddSalaryData empsalarydata);
        void UpdateEmployee(AddEmployee empData);
        void UpdateEmployeeSalaryData(AddSalaryData empsalarydata);
        int UpdateEmployeeData(int id, string Name, string exit_date, string SSN, bool is_active);
        int DeleteEmployeeDataAsync(int id); //soft Delete
    }
}
