using EbosTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EbosTask.Models
{
    public class LoginModel
    {
        [Display(Name ="Username")]
        [Required(ErrorMessage ="Plese enter username.")]
        public string username { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage ="Please Enter password.")]
        public string password { get; set; }

        [Required(ErrorMessage  = "Please Select Role type.")]
        public string RoleID { get; set; }
    }
}
