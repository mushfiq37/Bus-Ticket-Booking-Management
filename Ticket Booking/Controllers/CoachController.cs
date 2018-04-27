using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_Booking.Models;

namespace Ticket_Booking.Controllers
{
    public class CoachController : Controller
    {
        BinderModel binder = new BinderModel();
        // GET: /Coach/

        public ActionResult Index()
        {
            return View(binder.coach.ToList());
        }

        public ActionResult Create()
        {
            return View(new CoachModel());
        }

        [HttpPost]
        public ActionResult Save(CoachModel coach)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    binder.coach.Add(coach);
                    binder.SaveChanges();
                }
                catch (Exception e)
                {

                }

            }
            return RedirectToAction("Index"); ;
        }
        public ActionResult Delete(long id)
        {
            CoachModel ch = binder.coach.Find(id);
            binder.coach.Remove(ch);
            binder.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult Edit(long id)
        {
            CoachModel cm = binder.coach.Find(id);

            if (cm == null)
            {
                return HttpNotFound();
            }

            return View(cm);
        }

        [HttpPost]

        public ActionResult Edit(CoachModel chm)
        {
            if (ModelState.IsValid)
            {
                binder.Entry(chm).State = System.Data.Entity.EntityState.Modified;
                binder.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }
}
