using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Ticket_Booking.Models
{
    public class TripsModel
    {
       
        [Key]
        public long Id { get; set; }

        [Required]
        [Display(Name = "Coach Number: ")]
        public string CoachNo { get; set; }

        [Required]
        [Display(Name = "Starting Point: ")]
        
        public long RouteFrom { get; set; }

        [Required]
        [Display(Name = "Destination: ")]
        public long RouteTo { get; set; }

        [Required]
  
        [Display(Name = "Total Seats: ")]
        public int NumberOfSeat { get; set; }

        [Required]
        //[Compare(DateTime.Today.ToString())]
        [Display(Name = "Departure Time: ")]
        public TimeSpan DepartureTime { get; set; }

        [Required]
        [Display(Name = "Estimated Arrival Time: ")]
        public TimeSpan ArrivalTime { get; set; }

        [Required]
        [Display(Name = "Ticket Price: ")]
        public decimal Fare { get; set; }

        [Required]
        [Display(Name = "Coach Type: ")]
        public long CoachType { get; set; }

        [Required]
        [Display(Name = "No. of seats per row: ")]
        public int NoOfSeatPerRow { get; set; }


        [ForeignKey("RouteFrom")]
        public virtual LocationModel location { get; set; }

        [ForeignKey("CoachType")]
        public virtual CoachModel coach { get; set; }

        [ForeignKey("RouteTo")]
        public virtual LocationModel location2 { get; set; }

    }
}