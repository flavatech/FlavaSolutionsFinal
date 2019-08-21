﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FlavaSolutionsFinal.Models
{
    public class PaymentTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PaymentTypes
        public ActionResult Index()
        {
            return View(db.PaymentTypes.ToList());
        }

        // GET: PaymentTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentType paymentType = db.PaymentTypes.Find(id);
            if (paymentType == null)
            {
                return HttpNotFound();
            }
            return View(paymentType);
        }

        // GET: PaymentTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PaymentTypeID,PaymentName,Createdby,CreatedDate,ModifiedBy,ModifiedDate")] PaymentType paymentType)
        {
            if (ModelState.IsValid)
            {
                paymentType.CreatedDate = DateTime.Now;
                paymentType.Createdby = User.Identity.Name;
                db.PaymentTypes.Add(paymentType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paymentType);
        }

        // GET: PaymentTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentType paymentType = db.PaymentTypes.Find(id);
            if (paymentType == null)
            {
                return HttpNotFound();
            }
            return View(paymentType);
        }

        // POST: PaymentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PaymentTypeID,PaymentName,Createdby,CreatedDate,ModifiedBy,ModifiedDate")] PaymentType paymentType)
        {
            if (ModelState.IsValid)
            {
                paymentType.ModifiedDate = DateTime.Now;
                paymentType.ModifiedBy = User.Identity.Name;
                db.Entry(paymentType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymentType);
        }

        // GET: PaymentTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentType paymentType = db.PaymentTypes.Find(id);
            if (paymentType == null)
            {
                return HttpNotFound();
            }
            return View(paymentType);
        }

        // POST: PaymentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PaymentType paymentType = db.PaymentTypes.Find(id);
            db.PaymentTypes.Remove(paymentType);
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
