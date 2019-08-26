using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlavaSolutionsFinal.Models;

namespace FlavaSolutionsFinal.Controllers
{
    public class TransactionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Transactions
        public ActionResult Index()
        {
            var transactions = db.transactions.Include(t => t.Activity).Include(t => t.memberAccount).Include(t => t.PaymentType).Include(t => t.PeriodName).Include(t => t.Plan).Include(t => t.SalesTax);
            return View(transactions.ToList());
        }

        // GET: Transactions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaction transaction = db.transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            return View(transaction);
        }

        // GET: Transactions/Create
        public ActionResult Create()
        {
            ViewBag.ActivityID = new SelectList(db.activities, "ActivityID", "ActivityName");
            ViewBag.MemberID = new SelectList(db.memberAccounts, "MemberID", "UserName");
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "PaymentTypeID", "PaymentName");
            ViewBag.PeriodID = new SelectList(db.periods, "PeriodId", "PeriodName");
            ViewBag.PlanID = new SelectList(db.plans, "PlanID", "PlanName");
            ViewBag.TaxID = new SelectList(db.Taxes, "TaxID", "TaxName");
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TransactionId,MemberID,PlanID,ActivityID,PeriodID,PaymentTypeID,PaymentFromdt,PaymentTodt,AmountDue,TaxID,AmountPaid,Balance,NextRenwalDate,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                transaction.Balance = transaction.AmountDue - (transaction.AmountPaid);
                transaction.NextRenwalDate = transaction.PaymentTodt;
                transaction.CreatedDate = DateTime.Now;
                transaction.CreatedBy = User.Identity.Name;
                db.transactions.Add(transaction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActivityID = new SelectList(db.activities, "ActivityID", "ActivityName", transaction.ActivityID);
            ViewBag.MemberID = new SelectList(db.memberAccounts, "MemberID", "UserName", transaction.MemberID);
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "PaymentTypeID", "PaymentName", transaction.PaymentTypeID);
            ViewBag.PeriodID = new SelectList(db.periods, "PeriodId", "PeriodName", transaction.PeriodID);
            ViewBag.PlanID = new SelectList(db.plans, "PlanID", "PlanName", transaction.PlanID);
            ViewBag.TaxID = new SelectList(db.Taxes, "TaxID", "TaxName", transaction.TaxID);
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaction transaction = db.transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActivityID = new SelectList(db.activities, "ActivityID", "ActivityName", transaction.ActivityID);
            ViewBag.MemberID = new SelectList(db.memberAccounts, "MemberID", "UserName", transaction.MemberID);
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "PaymentTypeID", "PaymentName", transaction.PaymentTypeID);
            ViewBag.PeriodID = new SelectList(db.periods, "PeriodId", "PeriodName", transaction.PeriodID);
            ViewBag.PlanID = new SelectList(db.plans, "PlanID", "PlanName", transaction.PlanID);
            ViewBag.TaxID = new SelectList(db.Taxes, "TaxID", "TaxName", transaction.TaxID);
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TransactionId,MemberID,PlanID,ActivityID,PeriodID,PaymentTypeID,PaymentFromdt,PaymentTodt,AmountDue,TaxID,AmountPaid,Balance,NextRenwalDate,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                transaction.Balance = transaction.AmountDue - (transaction.AmountPaid);
                transaction.NextRenwalDate = transaction.PaymentTodt;
                transaction.ModifiedDate = DateTime.Now;
                transaction.ModifiedBy = User.Identity.Name;
                db.Entry(transaction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActivityID = new SelectList(db.activities, "ActivityID", "ActivityName", transaction.ActivityID);
            ViewBag.MemberID = new SelectList(db.memberAccounts, "MemberID", "UserName", transaction.MemberID);
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "PaymentTypeID", "PaymentName", transaction.PaymentTypeID);
            ViewBag.PeriodID = new SelectList(db.periods, "PeriodId", "PeriodName", transaction.PeriodID);
            ViewBag.PlanID = new SelectList(db.plans, "PlanID", "PlanName", transaction.PlanID);
            ViewBag.TaxID = new SelectList(db.Taxes, "TaxID", "TaxName", transaction.TaxID);
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaction transaction = db.transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transaction transaction = db.transactions.Find(id);
            db.transactions.Remove(transaction);
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
