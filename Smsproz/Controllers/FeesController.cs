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
    public class FeesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Fees
        public ActionResult Index()
        {
            var feesClas = db.FeesClas.Include(f => f.cla);
            return View(feesClas.ToList());
        }

        // GET: Fees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fees fees = db.FeesClas.Find(id);
            if (fees == null)
            {
                return HttpNotFound();
            }
            return View(fees);
        }

        // GET: Fees/Create
        public ActionResult Create()
        {
            ViewBag.ClaId = new SelectList(db.Clas, "Claid", "ClaName");
            return View();
        }

        // POST: Fees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FeesId,ClaId,FeesAmount")] Fees fees)
        {
            if (ModelState.IsValid)
            {
                db.FeesClas.Add(fees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClaId = new SelectList(db.Clas, "Claid", "ClaName", fees.ClaId);
            return View(fees);
        }

        // GET: Fees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fees fees = db.FeesClas.Find(id);
            if (fees == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClaId = new SelectList(db.Clas, "Claid", "ClaName", fees.ClaId);
            return View(fees);
        }

        // POST: Fees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FeesId,ClaId,FeesAmount")] Fees fees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClaId = new SelectList(db.Clas, "Claid", "ClaName", fees.ClaId);
            return View(fees);
        }

        // GET: Fees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fees fees = db.FeesClas.Find(id);
            if (fees == null)
            {
                return HttpNotFound();
            }
            return View(fees);
        }

        // POST: Fees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fees fees = db.FeesClas.Find(id);
            db.FeesClas.Remove(fees);
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
