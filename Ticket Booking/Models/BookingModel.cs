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
    public class BookingModel
    {

        [Key]
        public long Id { get; set; }

        public long PassengerId { get; set; }

        public long TripId { get; set; }

        [Required(ErrorMessage = "Boarding point is required")]
     
        public long BoardingPoint { get; set; }

        [Required(ErrorMessage = "Dropping point is required")]
        
        public long DroppingPoint { get; set; }

        [Required(ErrorMessage = "Payment method is required")]
        
        public string PaymentMethod { get; set; }

        [ForeignKey("PassengerId")]
        public virtual PassengerModel passenger{ get; set; }

        [ForeignKey("TripId")]
        public virtual TripsModel trps { get; set; }

        [ForeignKey("BoardingPoint")]
        public virtual LocationModel location { get; set; }

        [ForeignKey("DroppingPoint")]
        public virtual LocationModel location2 { get; set; }



    }
}