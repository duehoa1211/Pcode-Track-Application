using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace PData
{
    public class FULL_ADMINISTRATOR
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "USERNAME")]
        public string USER_NAMES { get; set; }

        [Required]
        [Display(Name = "PASSWORD")]
        public string PASSWORDS { get; set; }

        [Required]
        [Display(Name = "EMAIL")]
        public string EMAIL { get; set; }

        public string ADMIN_LOG { get; set; }

        public string IP_ADDRESS { get; set; }

        [Required]
        [Display(Name = "USERNAME")]
        public bool? ACTIVE { get; set; }

        [Required]
        public DateTime? LAST_LOGIN { get; set; }

        [Required]
        public string SKYPE_URL { get; set; }

    }
}
