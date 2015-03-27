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
    public class romedependenciesController : Controller
    {
        private endoriskContext db = new endoriskContext();

        // GET: romedependencies
        public ActionResult Index()
        {
            return View(db.romedependencies.ToList());
        }

        // GET: romedependencies/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            romedependency romedependency = db.romedependencies.Find(id);
            if (romedependency == null)
            {
                return HttpNotFound();
            }
            return View(romedependency);
        }

        // GET: romedependencies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: romedependencies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "disease,preDisease")] romedependency romedependency)
        {
            if (ModelState.IsValid)
            {
                db.romedependencies.Add(romedependency);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(romedependency);
        }

        // GET: romedependencies/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            romedependency romedependency = db.romedependencies.Find(id);
            if (romedependency == null)
            {
                return HttpNotFound();
            }
            return View(romedependency);
        }

        // POST: romedependencies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "disease,preDisease")] romedependency romedependency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(romedependency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(romedependency);
        }

        // GET: romedependencies/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            romedependency romedependency = db.romedependencies.Find(id);
            if (romedependency == null)
            {
                return HttpNotFound();
            }
            return View(romedependency);
        }

        // POST: romedependencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            romedependency romedependency = db.romedependencies.Find(id);
            db.romedependencies.Remove(romedependency);
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
