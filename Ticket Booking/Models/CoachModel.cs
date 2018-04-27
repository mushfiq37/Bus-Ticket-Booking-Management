using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticket_Booking.Models
{
    public class CoachModel
    {
        [Key]
        public long Id { get; set; }

        [Display(Name = "Enter Coach Type: ")]
        public string CoachType { get; set; }



    }
}