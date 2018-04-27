using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_Booking.Models;

namespace Ticket_Booking.Controllers
{
    public class TripsController : Controller
    {
        BinderModel binder = new BinderModel();
        // GET: /Trips/

        public ActionResult Index()
        {          
            ViewBag.placeName = new SelectList(binder.location, "Id", "PlaceName");

            ViewBag.destination = new SelectList(binder.destination, "Id","Destination");

            ViewBag.coachType = new SelectList(binder.coach, "Id", "CoachType");

            return View(binder.trips.ToList());
        }
        public ActionResult Search(long RouteFrom, long RouteTo, long CoachType)
        {   
             
            return View(binder.trips.Where(m => m.RouteFrom == RouteFrom && m.RouteTo == RouteTo && m.CoachType == CoachType).ToList());
        }

        public ActionResult Create()
        {
            ViewBag.placeName = new SelectList(binder.location, "Id", "PlaceName");

            ViewBag.coachType= new SelectList(binder.coach, "Id", "CoachType");


            return View(new TripsModel());
        }

        [HttpPost]
        public ActionResult Save(TripsModel trips)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    binder.trips.Add(trips);
                    binder.SaveChanges();
                }
                catch (Exception e)
                {

                }

            }
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            TripsModel trp = binder.trips.Find(id);
            binder.trips.Remove(trp);
            binder.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int id)
        {
            TripsModel trp = binder.trips.Find(id);

            if (trp == null)
            {
                return HttpNotFound();
            }

            ViewBag.placeName = new SelectList(binder.location, "Id", "PlaceName");

            ViewBag.coachType = new SelectList(binder.coach, "Id", "CoachType");

            return View(trp);
        }

        [HttpPost]

        public ActionResult Edit(TripsModel trip)
        {
            if (ModelState.IsValid)
            {
                binder.Entry(trip).State = System.Data.Entity.EntityState.Modified;
                binder.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }
}
