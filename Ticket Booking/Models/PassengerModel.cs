using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticket_Booking.Models
{
    public class PassengerModel
    {

        [Key]
        public long Id { get; set; }

        [Required]
        [Display(Name = "Passenger Name: ")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Mobile Number: ")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Display(Name = "Gender: ")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "Age: ")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address: ")]
        public string Address { get; set; }


        [Display(Name = "Passport/NID: ")]
        public string NID { get; set; }

        [Required(ErrorMessage = "Nationality is required")]
        [Display(Name = "Nationality: ")]
        public string Nationality { get; set; }


    }
}