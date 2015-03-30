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
    public class patientsymptomsController : Controller
    {
        private endoriskContext db = new endoriskContext();

        // GET: patientsymptoms
        public ActionResult Index()
        {
            return View(db.patientsymptoms.ToList());
        }

        // GET: patientsymptoms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            patientsymptom patientsymptom = db.patientsymptoms.Find(id);
            if (patientsymptom == null)
            {
                return HttpNotFound();
            }
            return View(patientsymptom);
        }

        // GET: patientsymptoms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: patientsymptoms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPatient,symptom")] patientsymptom patientsymptom)
        {
            if (ModelState.IsValid)
            {
                db.patientsymptoms.Add(patientsymptom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patientsymptom);
        }

        // GET: patientsymptoms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            patientsymptom patientsymptom = db.patientsymptoms.Find(id);
            if (patientsymptom == null)
            {
                return HttpNotFound();
            }
            return View(patientsymptom);
        }

        // POST: patientsymptoms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPatient,symptom")] patientsymptom patientsymptom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientsymptom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patientsymptom);
        }

        // GET: patientsymptoms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            patientsymptom patientsymptom = db.patientsymptoms.Find(id);
            if (patientsymptom == null)
            {
                return HttpNotFound();
            }
            return View(patientsymptom);
        }

        // POST: patientsymptoms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            patientsymptom patientsymptom = db.patientsymptoms.Find(id);
            db.patientsymptoms.Remove(patientsymptom);
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
