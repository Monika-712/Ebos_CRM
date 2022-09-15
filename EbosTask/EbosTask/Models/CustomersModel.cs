using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EbosTask.Models
{
    public class CustomersModel
    {
        public Guid CustomerId { get; set; }
        [Display(Name ="Customer Number")]
        [Required(ErrorMessage = "Please enter number.")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please Enter 10 digit")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-##-####}")]
        public long CustomerNo { get; set; }
        [Required(ErrorMessage = "Please enter name.")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please enter surname.")]
        [Display(Name = "Customer Surname")]
        public string Customersurname { get; set; }
        [Required(ErrorMessage = "Please enter address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter  postoce.")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Please select country.")]
        public string Country { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Please enter date of birth.")]
        public string DateofBirth { get; set; }

    }
}
