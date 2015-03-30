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
    public class symptomsController : Controller
    {
        private endoriskContext db = new endoriskContext();

        // GET: symptoms
        public ActionResult Index()
        {
            return View(db.symptoms.ToList());
        }

        // GET: symptoms/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            symptom symptom = db.symptoms.Find(id);
            if (symptom == null)
            {
                return HttpNotFound();
            }
            return View(symptom);
        }

        // GET: symptoms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: symptoms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "symptom1,abbr")] symptom symptom)
        {
            if (ModelState.IsValid)
            {
                db.symptoms.Add(symptom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(symptom);
        }

        // GET: symptoms/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            symptom symptom = db.symptoms.Find(id);
            if (symptom == null)
            {
                return HttpNotFound();
            }
            return View(symptom);
        }

        // POST: symptoms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "symptom1,abbr")] symptom symptom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(symptom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(symptom);
        }

        // GET: symptoms/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            symptom symptom = db.symptoms.Find(id);
            if (symptom == null)
            {
                return HttpNotFound();
            }
            return View(symptom);
        }

        // POST: symptoms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            symptom symptom = db.symptoms.Find(id);
            db.symptoms.Remove(symptom);
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
