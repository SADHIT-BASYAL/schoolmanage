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
    public class TeacherSubjectsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TeacherSubjects
        public ActionResult Index()
        {
            var teachersSubjectClas = db.TeachersSubjectClas.Include(t => t.cla);
            return View(teachersSubjectClas.ToList());
        }

        // GET: TeacherSubjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherSubject teacherSubject = db.TeachersSubjectClas.Find(id);
            if (teacherSubject == null)
            {
                return HttpNotFound();
            }
            return View(teacherSubject);
        }

        // GET: TeacherSubjects/Create
        public ActionResult Create()
        {
            ViewBag.claId = new SelectList(db.Clas, "Claid", "ClaName");
            return View();
        }

        // POST: TeacherSubjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,claId,SubjectId,TeacherId")] TeacherSubject teacherSubject)
        {
            if (ModelState.IsValid)
            {
                db.TeachersSubjectClas.Add(teacherSubject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.claId = new SelectList(db.Clas, "Claid", "ClaName", teacherSubject.claId);
            return View(teacherSubject);
        }

        // GET: TeacherSubjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherSubject teacherSubject = db.TeachersSubjectClas.Find(id);
            if (teacherSubject == null)
            {
                return HttpNotFound();
            }
            ViewBag.claId = new SelectList(db.Clas, "Claid", "ClaName", teacherSubject.claId);
            return View(teacherSubject);
        }

        // POST: TeacherSubjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,claId,SubjectId,TeacherId")] TeacherSubject teacherSubject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacherSubject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.claId = new SelectList(db.Clas, "Claid", "ClaName", teacherSubject.claId);
            return View(teacherSubject);
        }

        // GET: TeacherSubjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherSubject teacherSubject = db.TeachersSubjectClas.Find(id);
            if (teacherSubject == null)
            {
                return HttpNotFound();
            }
            return View(teacherSubject);
        }

        // POST: TeacherSubjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeacherSubject teacherSubject = db.TeachersSubjectClas.Find(id);
            db.TeachersSubjectClas.Remove(teacherSubject);
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
