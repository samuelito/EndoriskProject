using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EndoriskProject.Models;

namespace EndoriskProject.Controllers
{
    public class severitiesController : Controller
    {
        private endoriskContext db = new endoriskContext();

        // GET: severities
        public ActionResult Index()
        {
            return View(db.severities.ToList());
        }

        // GET: severities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            severity severity = db.severities.Find(id);
            if (severity == null)
            {
                return HttpNotFound();
            }
            return View(severity);
        }

        // GET: severities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: severities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idSeverity,idQuiz,severity1")] severity severity)
        {
            if (ModelState.IsValid)
            {
                db.severities.Add(severity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(severity);
        }

        // GET: severities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            severity severity = db.severities.Find(id);
            if (severity == null)
            {
                return HttpNotFound();
            }
            return View(severity);
        }

        // POST: severities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idSeverity,idQuiz,severity1")] severity severity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(severity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(severity);
        }

        // GET: severities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            severity severity = db.severities.Find(id);
            if (severity == null)
            {
                return HttpNotFound();
            }
            return View(severity);
        }

        // POST: severities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            severity severity = db.severities.Find(id);
            db.severities.Remove(severity);
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
