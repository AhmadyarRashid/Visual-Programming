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
    public class ReservedRoomsController : Controller
    {
        private hmsEntities db = new hmsEntities();

        // GET: ReservedRooms
        public ActionResult Index()
        {
            var reservedRooms = db.ReservedRooms.Include(r => r.Customer).Include(r => r.Room);
            return View(reservedRooms.ToList());
        }

        // GET: ReservedRooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReservedRoom reservedRoom = db.ReservedRooms.Find(id);
            if (reservedRoom == null)
            {
                return HttpNotFound();
            }
            return View(reservedRoom);
        }

        // GET: ReservedRooms/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "Name");
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Type");
            return View();
        }

        // POST: ReservedRooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ResID,RoomID,CustomerID,Nights,BookDate")] ReservedRoom reservedRoom)
        {
            if (ModelState.IsValid)
            {
                db.ReservedRooms.Add(reservedRoom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "Name", reservedRoom.CustomerID);
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Type", reservedRoom.RoomID);
            return View(reservedRoom);
        }

        // GET: ReservedRooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReservedRoom reservedRoom = db.ReservedRooms.Find(id);
            if (reservedRoom == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "Name", reservedRoom.CustomerID);
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Type", reservedRoom.RoomID);
            return View(reservedRoom);
        }

        // POST: ReservedRooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ResID,RoomID,CustomerID,Nights,BookDate")] ReservedRoom reservedRoom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reservedRoom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "Name", reservedRoom.CustomerID);
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Type", reservedRoom.RoomID);
            return View(reservedRoom);
        }

        // GET: ReservedRooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReservedRoom reservedRoom = db.ReservedRooms.Find(id);
            if (reservedRoom == null)
            {
                return HttpNotFound();
            }
            return View(reservedRoom);
        }

        // POST: ReservedRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReservedRoom reservedRoom = db.ReservedRooms.Find(id);
            db.ReservedRooms.Remove(reservedRoom);
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
    }
}
