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
    public class ReceptionistsController : Controller
    {
        private hmsEntities db = new hmsEntities();

        // GET: Receptionists
        public ActionResult Index()
        {
            return View(db.Receptionists.ToList());
        }

        // GET: Receptionists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receptionist receptionist = db.Receptionists.Find(id);
            if (receptionist == null)
            {
                return HttpNotFound();
            }
            return View(receptionist);
        }

        // GET: Receptionists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receptionists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecID,Name,Age,Contact,Salary")] Receptionist receptionist)
        {
            if (ModelState.IsValid)
            {
                db.Receptionists.Add(receptionist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(receptionist);
        }

        // GET: Receptionists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receptionist receptionist = db.Receptionists.Find(id);
            if (receptionist == null)
            {
                return HttpNotFound();
            }
            return View(receptionist);
        }

        // POST: Receptionists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecID,Name,Age,Contact,Salary")] Receptionist receptionist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(receptionist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receptionist);
        }

        // GET: Receptionists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receptionist receptionist = db.Receptionists.Find(id);
            if (receptionist == null)
            {
                return HttpNotFound();
            }
            return View(receptionist);
        }

        // POST: Receptionists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Receptionist receptionist = db.Receptionists.Find(id);
            db.Receptionists.Remove(receptionist);
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
