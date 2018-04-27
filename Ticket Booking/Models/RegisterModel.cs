using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Ticket_Booking.Models
{
    [Bind(Exclude = "Id")]
    public class RegisterModel
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage="Name Is Required!")]
        [Display(Name = "Name: ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Username Is Required!")]
        [Display(Name = "User Name: ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Is Required!")]
        [Display(Name = "Password: ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email Is Required!")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address Is Required!")]
        [Display(Name = "Address: ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Mobile No. Is Required!")]
        [Display(Name = "Mobile: ")]
        public string Mobile { get; set; }

    }
}