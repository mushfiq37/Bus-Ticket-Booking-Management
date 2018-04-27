using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticket_Booking.Models
{
    public class LocationModel
    {
        [Key]
        public long Id { get; set; }

        [Display(Name = "Enter Location:  ")]
        public string PlaceName { get; set; }


    }
}