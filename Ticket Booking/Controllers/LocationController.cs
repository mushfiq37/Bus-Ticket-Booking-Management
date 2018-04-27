using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_Booking.Models;

namespace Ticket_Booking.Controllers
{
    public class LocationController : Controller
    {

        BinderModel binder = new BinderModel();
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View(binder.location.ToList());
        }
        public ActionResult Create()
        {
            return View(new LocationModel());
        }

        [HttpPost]
        public ActionResult Save(LocationModel location)
        {
            if (ModelState.IsValid)
            {
                try {
                    binder.location.Add(location);
                    binder.SaveChanges();
                }
                catch (Exception e) { 

                }

            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            LocationModel lc = binder.location.Find(id);
            binder.location.Remove(lc);
            binder.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult Edit(long id)
        {
            LocationModel lm = binder.location.Find(id);
            if(lm ==null)
            {
                return HttpNotFound();
            }
            return View(lm);
        }
        [HttpPost]
        public ActionResult Edit(LocationModel lcm)
        {
            if (ModelState.IsValid)
            {
                binder.Entry(lcm).State = System.Data.Entity.EntityState.Modified;
                binder.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
