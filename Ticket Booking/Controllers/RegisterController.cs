using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Ticket_Booking.Models;

namespace Ticket_Booking.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        BinderModel binder = new BinderModel();
        public ActionResult Index()
        {
            return View(new RegisterModel());
        }

        [HttpPost]
        public ActionResult Save(RegisterModel register)
        {
           /* if(string.IsNullOrEmpty(register.Name))
            {
                ModelState.AddModelError("Name", "Name is compulsory");
                return RedirectToAction("Index", "Home");
            }*/
            if (ModelState.IsValid)
            {
                try
                {
                   
                    binder.register.Add(register);
                    binder.SaveChanges();

                    TempData["Success"] = "Registration Done Successfully....";
                }
                catch (Exception e)
                {

                }
                 
            }
           return RedirectToAction("Index","Home");
        }

        //Login

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(RegisterModel login)
        {
            var user = binder.register.Where(m=>m.UserName == login.UserName && m.Password == login.Password).FirstOrDefault();

            if (user != null)
            {
                Session["UserName"] = user.UserName.ToString();
                Session["Password"] = user.Password.ToString();
                global.logged = 1;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "username or password is wrong,");
            }

            return View();
        }


    }
}
