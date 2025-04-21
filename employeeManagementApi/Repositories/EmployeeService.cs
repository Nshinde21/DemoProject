using employeeManagementApi.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.Data.SqlClient;
using Npgsql;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace employeeManagementApi.Repositories
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public EmployeeService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<EmployeeData> GetAllEmployeeData() => _context.Employee.ToList();
        public IEnumerable<SalaryData> GetAlSalaryData() => _context.EmployeeSalary.ToList();

        public IEnumerable<GetAllEmployeesDataWithSalaries> GetAllEmployeesDataWithSalaries()
        {
            string sqlQuery = "select e.id, e.name, e.Personal_email, e.Work_email, " +
                                "e.joining_date, es.title, e.address, " +
                                "e.city, e.state, e.zip, e.created_date, e.updated_date, e.dob, " +
                                "es.total_payable_hours, es.from_date, es.to_date, " +
                                "es.gross_salary, es.net_salary, e.Is_active " +
                                "from project1.employee e " +
                                "left join project1.employeesalary es " +
                                "on es.employee_id = e.id " +
                                "where e.is_active = true"
                                ;

            var _allEmployeeData = _context.GetAllEmployeesDataWithSalaries.FromSqlRaw(sqlQuery).ToList();

            if (_allEmployeeData == null || _allEmployeeData.Count <= 0)
            {
                return null;
            }

            return _allEmployeeData;

        }
        public GetEmployeeSalaryDataById GetEmployeeSalaryDataById(int id)
        {
            string sqlQuery = "select e.id, e.name, es.title, " +
                                   "es.total_payable_hours, es.from_date, es.to_date, " +
                                   "es.net_salary, es.gross_salary, e.joining_date, e.is_active " +
                                   "from project1.employee e " +
                                   "left join project1.employeesalary es " +
                                   "on es.employee_id = e.id " +
                                   "where e.id = {0}";

            var _employeeSalaryDataById = _context.GetEmployeeSalaryDataById
            .FromSqlRaw(sqlQuery, id)
            .FirstOrDefault();

            if (_employeeSalaryDataById == null)
            {
                return null;
            }

            return _employeeSalaryDataById;
        }
        public IEnumerable<GetDistinctTitlesWithMinMaxSalaries> GetDistinctTitlesWithMinMaxSalaries()
        {

            string sqlQuery = "select distinct es.title, min(es.net_salary) as minNet_salary, max(es.net_salary) as maxNet_salary" +
                                " from project1.employeesalary es" +
                                " group by es.title";

            var _allDistinctTitleData = _context.GetDistinctTitlesWithMinMaxSalaries
            .FromSqlRaw(sqlQuery)
            .ToList();

            return _allDistinctTitleData;
        }
        public IEnumerable<GetAllEmployeesDataWithSalaries> GetEmpSalariesByTitle(string title)
        {

            string sqlQuery = string.Format("select e.id, e.name, e.Personal_email, e.Work_email, " +
                                "e.joining_date, es.title, e.address, " +
                                "e.city, e.state, e.zip, e.created_date, e.updated_date, e.dob, " +
                                "es.total_payable_hours, es.from_date, es.to_date, " +
                                "es.gross_salary, es.net_salary, e.Is_active " +
                                "from project1.employee e " +
                                "left join project1.employeesalary es " +
                                "on es.employee_id = e.id " +
                                "where lower(es.title) like '%{0}%' ", title?.ToLower());


            var _allEmployeeData = _context.GetAllEmployeesDataWithSalaries
            .FromSqlRaw(sqlQuery)
            .ToList();

            return _allEmployeeData;
        }
        public IEnumerable<GetAllEmployeesDataWithSalaries> GetEmployeesSalaryByName(string name)
        {

            string sqlQuery = string.Format("select e.id, e.name, e.Personal_email, e.Work_email, " +
                                "e.joining_date, es.title, e.address, " +
                                "e.city, e.state, e.zip, e.created_date, e.updated_date, e.dob, " +
                                "es.total_payable_hours, es.from_date, es.to_date, " +
                                "es.gross_salary, es.net_salary, e.Is_active " +
                                "from project1.employee e " +
                                "left join project1.employeesalary es " +
                                "on es.employee_id = e.id " +
                                "where lower(e.name) like '%{0}%' ", name.ToLower());

            var _allEmployeeData = _context.GetAllEmployeesDataWithSalaries
            .FromSqlRaw(sqlQuery)
            .ToList();

            return _allEmployeeData;
        }


        public IEnumerable<GetEmployeesByReportingManager> GetEmployeesByReportingManager(int id)
        {
            string sqlQuery = string.Format("select e.id, e.name, e.reporting_employee_id, em.name as manager " +
                "from " +
                "project1.employee e " +
                "left join project1.employee em " +
                "on e.reporting_employee_id = em.id " +
                "where e.reporting_employee_id = {0} ", id);

            Console.WriteLine(sqlQuery);

            var _allEmployeeData = _context.GetEmployeesByReportingManager
            .FromSqlRaw(sqlQuery)
            .ToList();

            return _allEmployeeData;
        }

        public IEnumerable<GetEmployeesByAge> GetEmployeesBelowAnAge(int age)
        {
            string sqlQuery = string.Format("select emp.* from (select id, name, dob, DATE_PART('year', AGE(dob))::numeric(5,2) AS age " +
                "from project1.employee ) as emp " +
                "where age < {0} ", age);

            var _allEmployeeData = _context.GetEmployeesByAge
            .FromSqlRaw(sqlQuery)
            .ToList();

            return _allEmployeeData;
        }
        public IEnumerable<GetEmployeesByAge> GetEmployeesAboveAnAge(int age)
        {
            string sqlQuery = string.Format("select emp.* from (select id, name, dob, DATE_PART('year', AGE(dob))::numeric(5,2) AS age " +
                "from project1.employee ) as emp " +
                "where age > {0} ", age);

            var _allEmployeeData = _context.GetEmployeesByAge
            .FromSqlRaw(sqlQuery, age)
            .ToList();

            return _allEmployeeData;
        }

        public void AddEmployee(AddEmployee empdata)
        {
            var employee = _mapper.Map<EmployeeData>(empdata);
            _context.Employee.Add(employee);
            _context.SaveChanges();
        }
        public void AddEmployeeSalary(AddSalaryData empsalarydata)
        {
            var employeeSalary = _mapper.Map<SalaryData>(empsalarydata);
            _context.EmployeeSalary.Add(employeeSalary);
            _context.SaveChanges();
        }
        public void UpdateEmployee(AddEmployee empData)
        {
            var employee = _mapper.Map<EmployeeData>(empData);
            _context.Employee.Add(employee);
            _context.SaveChanges();
        }
        public void UpdateEmployeeSalaryData(AddSalaryData empsalarydata)
        {
            var employeeSalary = _mapper.Map<SalaryData>(empsalarydata);
            _context.EmployeeSalary.Add(employeeSalary);
            _context.SaveChanges();
        }

        public int UpdateEmployeeData(int id, string Name, string exit_date, string SSN, bool is_active)
        {
            var _rowsAffected = 0;
            if (id > 0 && (!string.IsNullOrEmpty(Name) || !string.IsNullOrEmpty(SSN) || !string.IsNullOrEmpty(exit_date)))
            {
                List<string> queryParams =
                [
                    !string.IsNullOrEmpty(Name) && !string.IsNullOrWhiteSpace(Name) ? string.Format("Name = '{0}'", Name) : null,
                    !string.IsNullOrEmpty(exit_date) && !string.IsNullOrWhiteSpace(exit_date) ? 
                        string.Format("exit_date = '{0}'", DateTime.ParseExact(exit_date, "MM/dd/yyyy", CultureInfo.InvariantCulture) ) : null,
                    !string.IsNullOrEmpty(SSN) && !string.IsNullOrWhiteSpace(SSN) ? string.Format("SSN = '{0}'", SSN) : null,
                     string.Format("is_active = {0}", is_active)
                ];

                queryParams = queryParams.Where(x => !string.IsNullOrEmpty(x)).ToList();

                if (queryParams.Count > 0)
                {

                    var sqlQuery =
                        "update project1.employee set " + string.Join(',', queryParams) + string.Format(" where id = {0}", id);

                    if (!string.IsNullOrEmpty(sqlQuery))
                    {
                        _rowsAffected = _context.Database.ExecuteSqlRaw(sqlQuery);
                    }
                }
            }
            return _rowsAffected;
        }

        public int DeleteEmployeeDataAsync(int id)
        {
            string sqlQuery = string.Format(" update project1.employee  " +
                               "set is_active = false" +
                               "   where id =  {0} ", id);

            var _rowsAffected = _context.Database.ExecuteSqlRaw(sqlQuery);

            return _rowsAffected;

        } //soft Delete
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddEmployee, EmployeeData>();
            CreateMap<AddSalaryData, SalaryData>();
        }
    }

    public partial class ModifyExitDateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Exit_date",
                table: "Employee",
                nullable: true, // This allows nulls
                oldClrType: typeof(DateTime),
                oldNullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Exit_date",
                table: "Employee",
                nullable: true, // Make it NOT NULL again
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }


    public static class EmployeeDataEndpoints
    {
        public static void MapEmployeeDataEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/EmployeeData").WithTags(nameof(EmployeeData));

            group.MapGet("/", () =>
            {
                return new[] { new EmployeeData() };
            })
            .WithName("GetAllEmployeeData")
            .WithOpenApi();

            group.MapGet("/{id}", (int id) =>
            {
                //return new EmployeeData { ID = id };
            })
            .WithName("GetEmployeeDataById")
            .WithOpenApi();

            group.MapPut("/{id}", (int id, EmployeeData input) =>
            {
                return TypedResults.NoContent();
            })
            .WithName("UpdateEmployeeData")
            .WithOpenApi();

            group.MapPost("/", (EmployeeData model) =>
            {
                //return TypedResults.Created($"/api/EmployeeData/{model.ID}", model);
            })
            .WithName("CreateEmployeeData")
            .WithOpenApi();

            group.MapDelete("/{id}", (int id) =>
            {
                //return TypedResults.Ok(new EmployeeData { ID = id });
            })
            .WithName("DeleteEmployeeData")
            .WithOpenApi();
        }
    }
}