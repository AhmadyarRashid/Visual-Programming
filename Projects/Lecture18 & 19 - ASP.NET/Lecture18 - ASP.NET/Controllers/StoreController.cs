using Lecture18___ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture18___ASP.NET.Controllers
{

    public class StoreController : Controller
    {

        Album album = new Album(); //define album > right click > resolve to Models package

        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public string test() {
            return "<b>hello world<b>";
        }

        public int? details(int? id) { //nullable int. i.e. it can be null
            return id;
        }


        //viewdata
        //viewbag
        //viewdictionary

        /*
        public ActionResult Browse(String name) {
            ViewBag.Message = "Hello" + name;
            return View(); //will look for a view inside the Views/Store folder named Browse
        }
         
        */


        //can also get through the id through request method
        /*public ActionResult Browse() {
            string str = Request.QueryString["id"];
            ViewBag.Message = "Hello" + str;
            return View(); //will look for a view inside the Views/Store folder named Browse
        } */

        public ActionResult Browse() {
            string str = Request.Form["value"];
            ViewBag.Message = "Hello " + str + System.DateTime.Now;
            return View(); //will look for a view inside the Views/Store folder named Browse
        }


        public ActionResult View1() {
            return View();
        }

        //public ActionResult Lists() {

        //    List<string> newList = new List<string>() { "Monday", "Tuesday" };

        //    ViewBag.mahadList = newList;

        //    return View();
        //}

        public ActionResult Lists() { //passing a list of model class object

      

            List<Album> albumList = new List<Album>(){

                new Album{albumId = 12, artist = "mahad", title = "asd"},
                new Album{albumId = 11, artist = "aqib", title = "adqq"},
            };

            ViewBag.mahadList = albumList;

            return View();
        }


        public ActionResult AddAlbum() { //passing a list of model class object



            List<Album> albumList = new List<Album>(){

                new Album{albumId = 12, artist = "mahad", title = "asd"},
                new Album{albumId = 11, artist = "aqib", title = "adqq"},
            };

            ViewBag.mahadList = albumList;

            return View();
        }
        
    }
}