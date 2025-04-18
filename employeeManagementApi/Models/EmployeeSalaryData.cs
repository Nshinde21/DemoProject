using System.ComponentModel.DataAnnotations.Schema;

namespace employeeManagementApi.Models
{
    [Table("project1.employeesalary")]
    public class EmployeeSalaryData
    {
        [Column("id")]
        public int EpmSalaryId { get; set; }
        public int Employee_id { get; set; }
        public string? Title { get; set; }
        public decimal Total_payable_hours { get; set; }
        public DateTime From_date { get; set; }
        public DateTime To_Date { get; set; }
        public decimal Gross_salary { get; set; }
        public decimal Net_salary { get; set; }
        public DateTime salary_date { get; set; }
        [Column("created_date")]
        public DateTime EmpCreated_date { get; set; }
        [Column("updated_date")]
        public DateTime EmpUpdated_date { get; set; }

    }
}
