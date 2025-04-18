using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employeeManagementApi.Models
{
    public class EmployeeData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Personal_email { get; set; }
        public string? Work_email { get; set; }
        public string? SSN { get; set; }
        public DateTime DOB { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public int Reporting_employee_id { get; set; }
        public DateTime Joining_date { get; set; }
        public DateTime Exit_date { get; set; }
        public bool Is_active { get; set; }
        public string? Title { get; set; }
        public decimal Total_payable_hours { get; set; }
        public DateTime From_date { get; set; }
        public DateTime To_Date { get; set; }
        public decimal Gross_salary { get; set; }
        public decimal Net_salary { get; set; }
        public DateTime Salary_date { get; set; }
        public DateTime Created_date { get; set; }
        public DateTime Updated_date { get; set; }
    }

}
