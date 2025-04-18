using employeeManagementApi.Models;

namespace employeeManagementApi.Repositories
{
    public interface IEmployeeRepostory
    {
        IEnumerable<EmployeeData> GetAllEmployees();
        EmployeeData GetEmployeeData(int id);
        IEnumerable<EmployeeSalaryData> GetDistinctSalariesWithMinMax();
        IEnumerable<EmployeeSalaryData> GetEmpSalariesByTitle(string title);
        IEnumerable<EmployeeData> GetEmployeesByName(string name);
        IEnumerable<EmployeeData> GetEmployeeDataByTitle(string title);
        EmployeeData GetEmployeeDataById(int id)


    }
}
