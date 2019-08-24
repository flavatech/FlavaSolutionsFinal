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
    public class MemberAccountsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MemberAccounts
        public ActionResult Index()
        {
            return View(db.memberAccounts.ToList());
        }

        // GET: MemberAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberAccount memberAccount = db.memberAccounts.Find(id);
            if (memberAccount == null)
            {
                return HttpNotFound();
            }
            return View(memberAccount);
        }

        // GET: MemberAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberAccounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MemberID,UserName,Email,DateOfBirth,FirstName,LastName,MobilePhone")] MemberAccount memberAccount)
        {
            if (ModelState.IsValid)
            {
                db.memberAccounts.Add(memberAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(memberAccount);
        }

        // GET: MemberAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberAccount memberAccount = db.memberAccounts.Find(id);
            if (memberAccount == null)
            {
                return HttpNotFound();
            }
            return View(memberAccount);
        }

        // POST: MemberAccounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MemberID,UserName,Email,DateOfBirth,FirstName,LastName,MobilePhone")] MemberAccount memberAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(memberAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(memberAccount);
        }

        // GET: MemberAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberAccount memberAccount = db.memberAccounts.Find(id);
            if (memberAccount == null)
            {
                return HttpNotFound();
            }
            return View(memberAccount);
        }

        // POST: MemberAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MemberAccount memberAccount = db.memberAccounts.Find(id);
            db.memberAccounts.Remove(memberAccount);
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
