using System.Text.Json.Serialization;

namespace employeeManagementApi.Models
{
    public class GetEmployeesByAge
    {
        [JsonPropertyName("Employee Id")]
        public int id { get; set; }
        [JsonPropertyName("Employee Name")]
        public string name { get; set; }
        [JsonPropertyName("Employee Date of Birth")]
        public DateOnly dob { get; set; }
        [JsonPropertyName("Employee Age")]
        public decimal age { get; set; }
    }
}
