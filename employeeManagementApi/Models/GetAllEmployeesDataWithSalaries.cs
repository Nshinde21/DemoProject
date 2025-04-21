using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace employeeManagementApi.Models
{
    public class GetAllEmployeesDataWithSalaries
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Personal_email { get; set; }
        public string? Work_email { get; set; }
        public DateOnly? dob { get; set; }
        public string? Address { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zip { get; set; }
        public DateOnly? joining_date { get; set; }
        public decimal? Total_payable_hours { get; set; }
        public decimal? Gross_salary { get; set; }
        public decimal? Net_salary { get; set; }        
        [JsonPropertyName("Pay Period from date")]
        public DateOnly? from_date { get; set; }
        [JsonPropertyName("Pay Period to date")]
        public DateOnly? to_date { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }        
        public bool? Is_active { get; set; }
    }
}
