namespace employeeManagementApi.Models
{
    public class EmployeeData: EmployeeSalaryData
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Personal_email { get; set; }
        public string? Work_email { get; set; }
        public decimal SSN { get; set; }
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
        public DateTime Created_date { get; set; }
        public DateTime Updated_date { get; set; }
    }

}
