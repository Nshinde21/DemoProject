using employeeManagementApi.Models;
using employeeManagementApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace employeeManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDataAPIController : ControllerBase
    {
        private readonly IEmployeeService _repository;

        public EmployeeDataAPIController(IEmployeeService repository)
        {
            _repository = repository;
        }


        [HttpGet("GetAllEmployeesDataWithSalariesAsync")]
        public IActionResult GetAllEmployeesDataWithSalaries()
        {
            var product = _repository.GetAllEmployeesDataWithSalaries();
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet("GetEmployeeDataById")]
        public IActionResult GetEmployeeDataById(int id)
        {
            var product = _repository.GetEmployeeSalaryDataById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet("GetDistinctTitlesWithMinMaxSalaries")]
        public IActionResult GetDistinctTitlesWithMinMaxSalaries() => Ok(_repository.GetDistinctTitlesWithMinMaxSalaries());


        [HttpGet("GetEmpSalariesByTitle")]
        public IActionResult GetEmpSalariesByTitle(string title)
        {
            var product = _repository.GetEmpSalariesByTitle(title);
            if (product == null) return NotFound();
            return Ok(product);
        }


        [HttpGet("GetEmployeesByName")]
        public IActionResult GetEmployeesByName(string name)
        {
            var product = _repository.GetEmployeesSalaryByName(name);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet("GetEmployeesByReportingManager")]
        public IActionResult GetEmployeesReporting(int reportingManagerId)
        {
            var product = _repository.GetEmployeesByReportingManager(reportingManagerId);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet("GetEmployeesBelowAnAge")]
        public IActionResult GetEmployeesBelowAnAge(int belowAge)
        {
            var product = _repository.GetEmployeesBelowAnAge(belowAge);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet("GetEmployeesAboveAnAge")]
        public IActionResult GetEmployeesAboveAnAge(int aboveAge)
        {
            var product = _repository.GetEmployeesAboveAnAge(aboveAge);
            if (product == null) return NotFound();
            return Ok(product);
        }


        //[HttpPost("AddEmployee")]
        //public IActionResult AddEmployee(AddEmployee empdata)
        //{
        //    _repository.AddEmployee(empdata);
        //    return Ok();
        //}

        //[HttpPost("AddEmployeeSalary")]
        //public IActionResult AddEmployeeSalary(AddSalaryData empsalarydata)
        //{
        //    _repository.AddEmployeeSalary(empsalarydata);
        //    return Ok();
        //}


        [HttpPost("UpdateEmployeeData")]
        public IActionResult UpdateEmployee(int id, bool is_active, string Name = "", string exit_date = "", string SSN = "")
        {

            _repository.UpdateEmployeeData(id, Name, exit_date, SSN, is_active);
            return Ok();
        }

        [HttpGet("DeleteEmployeeDataAsync")]
        public IActionResult DeleteEmployeeDataAsync(int empid)
        {
            _repository.DeleteEmployeeDataAsync(empid);
            return Ok();
        }
    }
}
