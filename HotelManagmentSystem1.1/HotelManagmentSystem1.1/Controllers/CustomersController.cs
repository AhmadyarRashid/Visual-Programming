using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HotelManagmentSystem1._1.Models;

namespace HotelManagmentSystem1._1.Controllers
{
    public class CustomersController : Controller
    {

        private hmsEntities dc = new hmsEntities();
        private hmsEntities db = new hmsEntities();

        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }


        
        //Booking
        public ActionResult Booking()
        {
            
            var user = Request.Form["user"];
            var contact = Request.Form["contact"];
            var address = Request.Form["address"];
            var single = Request.Form["single"];
            var doubleRoom = Request.Form["double"];
            var Nightssingle = Request.Form["singleNights"];
            var NightsDouble = Request.Form["doubleNights"];

            ViewBag.name = user + contact + address + single + doubleRoom + Nightssingle + NightsDouble;
            if(user != null && contact != null && address != null)
            {
                Customer customer = new Customer
                {
                    Name = user,
                    Contact = contact,
                    Age = address
                };
                dc.Customers.Add(customer);
                dc.SaveChangesAsync();
            }
           
           
            if(single != null && Nightssingle != null)
            {
                SingleRoomBooked(int.Parse(single), int.Parse(Nightssingle));
            }
          
          //  DoubleRoomBooked(2,2);
           




            return View();
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,Name,Age,Contact")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,Name,Age,Contact")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        // Booking for single room
        private void SingleRoomBooked(int userInput , int nights)
        {
            // bool check = false;
            // get all single available room
            var getSingleRoom = dc.Rooms.Where(room => room.Type == "Single" && room.Status == "Available");
            // count single room available ???????? batao ??
            int totalSingleRoom = 0;
            foreach (var a in getSingleRoom)
            {
                totalSingleRoom++;
            }
            ViewBag.rooms = totalSingleRoom;
          
/*
            int tempRoom = 0;
            if (userInput <= totalSingleRoom)
            {
                foreach (var a in getSingleRoom)
                {
                    // so then we booked room
                    ReservedRoom reserver = new ReservedRoom
                    {
                        CustomerID = 6,
                        RoomID = a.RoomID,
                        Nights = nights.ToString(),
                        BookDate = System.DateTime.Now.ToString()
                    };
                    // update status of room 
                    a.Status = "Booked";
                    dc.SaveChangesAsync();
                    dc.ReservedRooms.Add(reserver);
                    dc.SaveChangesAsync();
                  //  db.Entry(a).State = EntityState.Modified;
                    // submit changed kysa kartay hai ??
                   
                   
                    // then we compare from user input field
                    tempRoom++;
                    if (userInput == tempRoom) //yeh check to lagaya hain na tuney uper woh sirf query run k liya tha
                    {
                        
                        break;
                       
                    }
                }
            }
            else
            {
                // if user input is invalid
               
            }
            
    */

        }



        // booked double room
        private void DoubleRoomBooked(int userInput, int nights)
        {
            
            // get all single available room
            var getDoubleRoom = from q in dc.Rooms
                                where q.Type == "Double" && q.Status == "Available"
                                select q;
            // count single room available ???????? batao ??
            int totalDoubleRoom = getDoubleRoom.Count();

            int tempRoom = 0;
            if (userInput <= totalDoubleRoom)
            {
                foreach (var a in getDoubleRoom)
                {
                    // so then we booked room
                    ReservedRoom reserver = new ReservedRoom
                    {
                        CustomerID = 2,
                        RoomID = a.RoomID,
                        Nights = nights.ToString(),
                        BookDate = System.DateTime.Now.ToString()
                    };
                    // update status of room 
                    a.Status = "Booked";
                    // submit changed kysa kartay hai ??
                    dc.SaveChanges(); //level
                    dc.ReservedRooms.Add(reserver);
                    // then we compare from user input field
                    tempRoom++;
                    if (userInput == tempRoom) //yeh check to lagaya hain na tuney uper woh sirf query run k liya tha
                    {
                     
                        break;

                    }
                }
            }
            else
            {
                // if user input is invalid
             
            }
         


        }
    }

    
}
