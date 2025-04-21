using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace employeeManagementApi.Models
{
    public class AddSalaryData
    {
        public int Employee_id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public decimal Total_payable_hours { get; set; }

        [JsonPropertyName("Pay Period from date")]
        public DateOnly From_date { get; set; }
        [JsonPropertyName("Pay Period to date")]
        public DateTime To_Date { get; set; }
        public decimal Gross_salary { get; set; }
        public decimal Net_salary { get; set; }
        public DateOnly salary_date { get; set; }
        public DateTime created_date { get; set; } = DateTime.Now;
        public DateTime updated_date { get; set; } = DateTime.Now;
    }
}
