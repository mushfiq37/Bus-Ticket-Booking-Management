using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticket_Booking.Models
{
    public class BookingList
    {
        [Key]
        public long Id { get; set; }

        public long BookingId { get; set; }

        public string SeatNo { get; set; }

    }
}