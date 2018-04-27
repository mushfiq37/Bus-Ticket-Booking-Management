using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_Booking.Models;

namespace Ticket_Booking.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        BinderModel binder = new BinderModel();
        public ActionResult Index()
        {
            ViewBag.placeName = new SelectList(binder.location, "Id", "PlaceName");

            ViewBag.coachType = new SelectList(binder.coach, "Id", "CoachType");

            return View();
        }

    }
}
