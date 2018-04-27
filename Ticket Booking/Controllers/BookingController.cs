using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_Booking.Models;
using System.Text.RegularExpressions;

namespace Ticket_Booking.Controllers
{
    public class BookingController : Controller
    {
        //
        // GET: /Booking/
        BinderModel binder = new BinderModel();
        public static long trpId;
        public ActionResult Index(long id)
        {
            trpId = id;

            ViewBag.boardingPoint = new SelectList(binder.location, "Id", "PlaceName");

            ViewBag.booking = binder.booking;
            ViewBag.bookingList = binder.bookingList;
            ViewBag.fare = binder.trips.Find(id).Fare;
            ViewBag.numberOfSeat=binder.trips.Find(id).NumberOfSeat;
            ViewBag.noOfSeatPerRow = binder.trips.Find(id).NoOfSeatPerRow;


            long[] bookingIds = binder.booking.Where(m => m.TripId == id).Select(m => m.Id).AsEnumerable().ToArray();

            string [] bookedSeats = new string[binder.trips.Find(id).NumberOfSeat];
            int counter = 0;
            foreach (long singleBooking in bookingIds)
            {
                string[] seats = binder.bookingList.Where(m => m.BookingId == singleBooking).Select(m => m.SeatNo).AsEnumerable().ToArray();
                foreach (string seat in seats)
                {
                    bookedSeats[counter] = seat;
                    counter++;
                }
            }

            ViewBag.bookedSeats = bookedSeats;

            return View("FrontLayout", new PassengerModel());
            
        }




        [HttpPost]
        public ActionResult Save(PassengerModel model, string selectedSeats, long boardingPoint, long droppingPoint, string payment)       
        {                  
            if (ModelState.IsValid)
            {
                try
                {

                    binder.passenger.Add(model);
                    binder.SaveChanges();

                    BookingModel bkModel = new BookingModel();
                    bkModel.PassengerId = model.Id;                
                    bkModel.TripId = trpId;
                    bkModel.BoardingPoint = boardingPoint;
                    bkModel.DroppingPoint = droppingPoint;
                    bkModel.PaymentMethod = payment;
                    binder.booking.Add(bkModel);
                    binder.SaveChanges();

                    string[] seat = selectedSeats.Split(' ');

                    for (int i = 0; i < seat.Length-1; i++) { 

                        BookingList bkList = new BookingList();
                        bkList.BookingId = bkModel.Id;
                        bkList.SeatNo = seat[i];
                        binder.bookingList.Add(bkList);
                        binder.SaveChanges();
                    }
                }
                catch (Exception e)
                {

                }

            }

            return RedirectToAction("Index", "Home");
        }

    }
}
