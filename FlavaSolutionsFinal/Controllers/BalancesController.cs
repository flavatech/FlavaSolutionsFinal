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
    public class BalancesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Balances
        public ActionResult Index()
        {
            var balances = db.Balances.Include(b => b.memberAccount).Include(b => b.PaymentAmount).Include(b => b.PaymentType).Include(b => b.planamount).Include(b => b.salestax);
            return View(balances.ToList());
        }

        // GET: Balances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Balance balance = db.Balances.Find(id);
            if (balance == null)
            {
                return HttpNotFound();
            }
            return View(balance);
        }

        // GET: Balances/Create
        public ActionResult Create()
        {
            ViewBag.MemberID = new SelectList(db.memberAccounts, "MemberID", "UserName");
            ViewBag.TransactionID = new SelectList(db.transactions, "TransactionId", "CreatedBy");
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "PaymentTypeID", "PaymentName");
            ViewBag.PlanID = new SelectList(db.plans, "PlanID", "PlanName");
            ViewBag.TaxID = new SelectList(db.Taxes, "TaxID", "SalesTax");
            return View();
        }

        // POST: Balances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaxID,BalanceID,MemberID,CreatedDate,PaymentTypeID,PlanID,TransactionID,MBalance,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,Id,UserName")] Balance balance)
        {
            if (ModelState.IsValid)
            {

                balance.CreatedDate = DateTime.Now;
            
                db.Balances.Add(balance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MemberID = new SelectList(db.memberAccounts, "MemberID", "UserName", balance.MemberID);
            ViewBag.TransactionID = new SelectList(db.transactions, "TransactionId", "CreatedBy", balance.TransactionID);
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "PaymentTypeID", "PaymentName", balance.PaymentTypeID);
            ViewBag.PlanID = new SelectList(db.plans, "PlanID", "PlanName", balance.PlanID);
            ViewBag.TaxID = new SelectList(db.Taxes, "TaxID", "SalesTax", balance.TaxID);
            return View(balance);
        }

        // GET: Balances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Balance balance = db.Balances.Find(id);
            if (balance == null)
            {
                return HttpNotFound();
            }
            ViewBag.MemberID = new SelectList(db.memberAccounts, "MemberID", "UserName", balance.MemberID);
            ViewBag.TransactionID = new SelectList(db.transactions, "TransactionId", "CreatedBy", balance.TransactionID);
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "PaymentTypeID", "PaymentName", balance.PaymentTypeID);
            ViewBag.PlanID = new SelectList(db.plans, "PlanID", "PlanName", balance.PlanID);
            ViewBag.TaxID = new SelectList(db.Taxes, "TaxID", "SalesTax", balance.TaxID);

            return View(balance);
        }

        // POST: Balances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaxID,BalanceID,MemberID,CreatedDate,PaymentTypeID,PlanID,TransactionID,MBalance,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,Id,UserName")] Balance balance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(balance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MemberID = new SelectList(db.memberAccounts, "MemberID", "UserName", balance.MemberID);
            ViewBag.TransactionID = new SelectList(db.transactions, "TransactionId", "CreatedBy", balance.TransactionID);
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "PaymentTypeID", "PaymentName", balance.PaymentTypeID);
            ViewBag.PlanID = new SelectList(db.plans, "PlanID", "PlanName", balance.PlanID);
            ViewBag.TaxID = new SelectList(db.Taxes, "TaxID", "SalesTax", balance.TaxID);

            return View(balance);
        }

        // GET: Balances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Balance balance = db.Balances.Find(id);
            if (balance == null)
            {
                return HttpNotFound();
            }
            return View(balance);
        }

        // POST: Balances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Balance balance = db.Balances.Find(id);
            db.Balances.Remove(balance);
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
