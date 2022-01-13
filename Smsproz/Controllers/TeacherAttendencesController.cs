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
    public class TeacherAttendencesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TeacherAttendences
        public ActionResult Index()
        {
            var teachersAttendenceClas = db.TeachersAttendenceClas.Include(t => t.Teacher);
            return View(teachersAttendenceClas.ToList());
        }

        // GET: TeacherAttendences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherAttendence teacherAttendence = db.TeachersAttendenceClas.Find(id);
            if (teacherAttendence == null)
            {
                return HttpNotFound();
            }
            return View(teacherAttendence);
        }

        // GET: TeacherAttendences/Create
        public ActionResult Create()
        {
            ViewBag.TeacherId = new SelectList(db.TeachersClas, "TeacherId", "TeacherName");
            return View();
        }

        // POST: TeacherAttendences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TeacherId,Status,GetDateTime")] TeacherAttendence teacherAttendence)
        {
            if (ModelState.IsValid)
            {
                db.TeachersAttendenceClas.Add(teacherAttendence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeacherId = new SelectList(db.TeachersClas, "TeacherId", "TeacherName", teacherAttendence.TeacherId);
            return View(teacherAttendence);
        }

        // GET: TeacherAttendences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherAttendence teacherAttendence = db.TeachersAttendenceClas.Find(id);
            if (teacherAttendence == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeacherId = new SelectList(db.TeachersClas, "TeacherId", "TeacherName", teacherAttendence.TeacherId);
            return View(teacherAttendence);
        }

        // POST: TeacherAttendences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TeacherId,Status,GetDateTime")] TeacherAttendence teacherAttendence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacherAttendence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeacherId = new SelectList(db.TeachersClas, "TeacherId", "TeacherName", teacherAttendence.TeacherId);
            return View(teacherAttendence);
        }

        // GET: TeacherAttendences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherAttendence teacherAttendence = db.TeachersAttendenceClas.Find(id);
            if (teacherAttendence == null)
            {
                return HttpNotFound();
            }
            return View(teacherAttendence);
        }

        // POST: TeacherAttendences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeacherAttendence teacherAttendence = db.TeachersAttendenceClas.Find(id);
            db.TeachersAttendenceClas.Remove(teacherAttendence);
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
