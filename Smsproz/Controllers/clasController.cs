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
    public class clasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: clas
        public ActionResult Index()
        {
            return View(db.Clas.ToList());
        }

        // GET: clas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cla cla = db.Clas.Find(id);
            if (cla == null)
            {
                return HttpNotFound();
            }
            return View(cla);
        }

        // GET: clas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: clas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Claid,ClaName")] cla cla)
        {
            if (ModelState.IsValid)
            {
                db.Clas.Add(cla);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cla);
        }

        // GET: clas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cla cla = db.Clas.Find(id);
            if (cla == null)
            {
                return HttpNotFound();
            }
            return View(cla);
        }

        // POST: clas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Claid,ClaName")] cla cla)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cla).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cla);
        }

        // GET: clas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cla cla = db.Clas.Find(id);
            if (cla == null)
            {
                return HttpNotFound();
            }
            return View(cla);
        }

        // POST: clas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cla cla = db.Clas.Find(id);
            db.Clas.Remove(cla);
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
