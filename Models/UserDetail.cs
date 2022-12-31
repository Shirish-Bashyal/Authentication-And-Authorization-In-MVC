using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Authentication_And_Authorization_In_MVC.Models
{
    public class UserDetail
    {

        public int UserId { get; set; }

        [Required]
        [Display(Name = "Full Name")]          // this will be shown in UI not the dataname.
        public string FullName { get; set; }=String.Empty;
       
        
        [Required]
        [Display(Name = "Address")]
        public string Address{ get; set; }=String.Empty;
       
        
        [Required]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }


        [Required]
        [Display(Name = "Role")]
        public int Role { get; set; }





        [Required]
        [Display(Name = "Email")]

        public string Email { get; set; } = string.Empty;



        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;







    }
}
