using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FlavaSolutionsFinal.Models
{
    public class PlansController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Plans
        public ActionResult Index()
        {
            var plans = db.plans.Include(p => p.Activity).Include(p => p.Period);
            return View(plans.ToList());
        }

        // GET: Plans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = db.plans.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // GET: Plans/Create
        public ActionResult Create()
        {
            ViewBag.ActivityID = new SelectList(db.activities, "ActivityID", "ActivityName");
            ViewBag.PeriodID = new SelectList(db.periods, "PeriodId", "Year");
            return View();
        }

        // POST: Plans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlanID,PlanName,PlanAmount,RecStatus,ActivityID,PeriodID,TotalAmout,CreatedDate,Createdby,ModifiedBy,ModifiedDate")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                plan.CreatedDate = DateTime.Now;
                plan.Createdby = User.Identity.Name;
                db.plans.Add(plan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActivityID = new SelectList(db.activities, "ActivityID", "ActivityName", plan.ActivityID);
            ViewBag.PeriodID = new SelectList(db.periods, "PeriodId", "Year", plan.PeriodID);
            return View(plan);
        }

        // GET: Plans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = db.plans.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActivityID = new SelectList(db.activities, "ActivityID", "ActivityName", plan.ActivityID);
            ViewBag.PeriodID = new SelectList(db.periods, "PeriodId", "Year", plan.PeriodID);
            return View(plan);
        }

        // POST: Plans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlanID,PlanName,PlanAmount,RecStatus,ActivityID,PeriodID,TotalAmout,CreatedDate,Createdby,ModifiedBy,ModifiedDate")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                plan.ModifiedDate = DateTime.Now;
                plan.ModifiedBy = User.Identity.Name;
                db.Entry(plan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActivityID = new SelectList(db.activities, "ActivityID", "ActivityName", plan.ActivityID);
            ViewBag.PeriodID = new SelectList(db.periods, "PeriodId", "Year", plan.PeriodID);
            return View(plan);
        }

        // GET: Plans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = db.plans.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // POST: Plans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plan plan = db.plans.Find(id);
            db.plans.Remove(plan);
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
