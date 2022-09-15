using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EbosTask.Models
{
    public class CallsModel
    {
        public int Callid { get; set; }
        [Required(ErrorMessage = "Please select number.")]
        public Guid CustomerId { get; set; }
       
        [Display(Name = "Customer No")]
        public long Customerno { get; set; }
        [Required(ErrorMessage = "Please enter date of call.")]
        [Display(Name = "Date Of Call")]
        public string DateofCall { get; set; }
        [Required(ErrorMessage = "Please enter time of call.")]
        [Display(Name = "Date Of Call")]
        public string TimeofCall { get; set; }
        [Required(ErrorMessage = "Please enter subject.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please enter description.")]
        public string Description { get; set; }
       
    }
}
