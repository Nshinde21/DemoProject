using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace employeeManagementApi.Models
{
    public class GetEmployeesByReportingManager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("Employee Id")]
        public int id { get; set; }
        public string name { get; set; }
     
        [JsonPropertyName("Manager Id")]
        public int reporting_employee_id { get; set; }
        [JsonPropertyName("Manager Name")] 
        public string manager { get; set; }
    }
}
