using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Ticket_Booking.Models
{
    public class CounterModel
    {
        [Key]

        public long Id { get; set; }

        [Required]
        [Display(Name = "Place Name: ")]
        public long LocationId { get; set; }

        [Required]
        [Display(Name = "Counter Name: ")]
        public string Counter { get; set; }

        [ForeignKey("LocationId")]
        public virtual LocationModel counterLocation { get; set; }
    }
}