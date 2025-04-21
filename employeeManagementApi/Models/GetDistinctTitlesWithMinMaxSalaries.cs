using employeeManagementApi.Models;
using Microsoft.Build.ObjectModelRemoting;
using Microsoft.EntityFrameworkCore;

namespace employeeManagementApi.Models
{
    public class GetDistinctTitlesWithMinMaxSalaries
    {
       public string title { get; set; }
       public decimal minNet_salary { get; set; }
       public decimal maxNet_salary { get; set; }

    }
    }



