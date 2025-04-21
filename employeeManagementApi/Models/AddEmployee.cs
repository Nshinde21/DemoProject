using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace employeeManagementApi.Models
{
    public class AddEmployee
    {
        public string? Name { get; set; } = string.Empty;
        public string? Personal_email { get; set; } = string.Empty;
        public string? Work_email { get; set; } = string.Empty;
        public string? SSN { get; set; } = string.Empty;
        public DateOnly? DOB { get; set; } = null;
        public string? Address { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty;
        public string? State { get; set; } = string.Empty;
        public string? Zip { get; set; } = string.Empty;
        public string? Phone { get; set; } = string.Empty;
        public int? Reporting_employee_id { get; set; } = 0;
        public DateOnly? Joining_date { get; set; }
        public DateTime? Exit_date { get; set; }
        public bool Is_active { get; set; }
        public DateTime Created_date { get; set; } = DateTime.Now;
        public DateTime Updated_date { get; set; } = DateTime.Now;
    }
}
