using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace PData
{ 
    public class ISSUES 
{
    public int ID { get; set; } 

    public string TITLE { get; set; } 

    public string ISSUES_DESCRIPTION { get; set; } 

    public int? CREATED_BY { get; set; } 

    public DateTime? UPDATED_TIME { get; set; } 

    public string ASSIGN_TO { get; set; } 

    public int? STATE_ID { get; set; } 

    public float? ATTEMP_TIME { get; set; } 

    public DateTime? DEAD_TIME { get; set; } 

    public int? PROJECT_ID { get; set; } 

    public int? PRIORITY_ID { get; set; } 

}
} 
            