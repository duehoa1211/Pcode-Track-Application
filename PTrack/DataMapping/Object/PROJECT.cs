using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace PData
{ 
    public class PROJECT 
{
    public int ID { get; set; } 

    public string PROJECT_NAME { get; set; } 

    public string PROJECT_DESCRIPTION { get; set; } 

    public DateTime? CREATED_DATE { get; set; } 

    public DateTime? UPDATED_DATE { get; set; } 

    public string PROJECT_LOG { get; set; } 

    public bool? ACTIVE { get; set; } 

    public int? ID_TYPE { get; set; } 

    public string KEY_WORDS { get; set; } 

}
} 
            