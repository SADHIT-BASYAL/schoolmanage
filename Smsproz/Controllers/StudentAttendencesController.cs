using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Smsproz.Models;

namespace Smsproz.Controllers
{
    public class StudentAttendencesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentAttendences
        public ActionResult Index()
        {
            return View(db.StudentAttendenceClas.ToList());
        }

        // GET: StudentAttendences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAttendence studentAttendence = db.StudentAttendenceClas.Find(id);
            if (studentAttendence == null)
            {
                return HttpNotFound();
            }
            return View(studentAttendence);
        }

        // GET: StudentAttendences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentAttendences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ClaId,SubjectId,RollNumber,Status,DateTime")] StudentAttendence studentAttendence)
        {
            if (ModelState.IsValid)
            {
                db.StudentAttendenceClas.Add(studentAttendence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentAttendence);
        }

        // GET: StudentAttendences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAttendence studentAttendence = db.StudentAttendenceClas.Find(id);
            if (studentAttendence == null)
            {
                return HttpNotFound();
            }
            return View(studentAttendence);
        }

        // POST: StudentAttendences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClaId,SubjectId,RollNumber,Status,DateTime")] StudentAttendence studentAttendence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentAttendence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentAttendence);
        }

        // GET: StudentAttendences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAttendence studentAttendence = db.StudentAttendenceClas.Find(id);
            if (studentAttendence == null)
            {
                return HttpNotFound();
            }
            return View(studentAttendence);
        }

        // POST: StudentAttendences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentAttendence studentAttendence = db.StudentAttendenceClas.Find(id);
            db.StudentAttendenceClas.Remove(studentAttendence);
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
