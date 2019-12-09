using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp1.Models;

namespace asp1.Controllers
{
    public class person
    {
        public String name { get; set; }
        public String age { get; set; }
        public String contact { get; set; }
    }
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public String test()
        {
            return "hello world";
        }

        public String test2(int? name)
        {
            return "Welcome " + name;
        }

        public ActionResult Browser()
        {
            String data = Request.Form["email"];
            ViewBag.heading = data + System.DateTime.Now;
        
            return View();
        }

        public ActionResult List()
        {
            String[] Cities = { "islamabad", "lahore", "karachi", "faizlabad" };
            ViewBag.cities = Cities;

            List<person> plist = new List<person>
            {
                new person{name = "ahmad", age = "19" , contact="0313 1539336"},
                 new person{name = "noman", age = "21" , contact="0313 123456789"}
            };
            ViewBag.plist = plist;

            List<customer> pcus = new List<customer> { 
               new customer{first_name = "ahmad" , last_name = "yar" , email="ahmedyar@gmail.com"},
               new customer{first_name = "noman" , last_name = "waris" , email="nomanwaris@gmail.com"}
            };
            ViewBag.pcus = pcus;
            return View();
        }
    }
}