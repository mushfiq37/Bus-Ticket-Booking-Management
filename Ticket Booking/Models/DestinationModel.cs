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
    public class DestinationModel
    {
        [Key]

        public long Id { get; set; }

        [Required]
        public long StartingId { get; set; }

        [Required]
        public string Destination { get; set; }

        [ForeignKey("StartingId")]

        public virtual TripsModel startingPoint { get; set; }
    }
}