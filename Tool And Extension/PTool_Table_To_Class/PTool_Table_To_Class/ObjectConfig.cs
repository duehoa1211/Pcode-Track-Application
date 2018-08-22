using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTool_Table_To_Class
{
    public class ObjectConfig
    {
        public string Connect { get; set; }
        public string TempCreate_Cs { get; set; }
        public ObjectConfig(string conn_string)
        {
            Connect = conn_string;
            TempCreate_Cs = @"using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace PData
{ 
    $$$datavalue$$$
} 
            ";
        }
    }
}
