using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hotelManagemntsSystem.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Booking()
        {
            var user = Request.Form["user"];
            var contact = Request.Form["contact"];
            var address = Request.Form["address"];
            var single = Request.Form["single"];
            var doubleRoom = Request.Form["double"];
            var Nightssingle = Request.Form["singleNights"];
            var NightsDouble = Request.Form["doubleNights"];

            
            return View();
        }
    }
}