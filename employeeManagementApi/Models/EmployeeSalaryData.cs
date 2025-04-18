using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employeeManagementApi.Models
{
    
    public class EmployeeSalaryData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EpmSalaryId { get; set; }
        public int Employee_id { get; set; }
        public string? Title { get; set; }
        public decimal Total_payable_hours { get; set; }
        public DateTime From_date { get; set; }
        public DateTime To_Date { get; set; }
        public decimal Gross_salary { get; set; }
        public decimal Net_salary { get; set; }
        public DateTime salary_date { get; set; }
        
        public DateTime EmpCreated_date { get; set; }
        
        public DateTime EmpUpdated_date { get; set; }

    }
}
