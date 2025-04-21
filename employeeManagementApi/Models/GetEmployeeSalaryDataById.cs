using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace employeeManagementApi.Models
{
    public class GetEmployeeSalaryDataById
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? title { get; set; }
        public decimal total_payable_hours { get; set; }
        public decimal? gross_salary { get; set; }
        public decimal net_salary { get; set; }
        [JsonPropertyName("Pay Period from date")]
        public DateOnly from_date { get; set; }
        [JsonPropertyName("Pay Period to date")]
        public DateOnly? to_date { get; set; }
        public DateOnly? joining_date { get; set; }
        public bool? is_active { get; set; }
    }
}
