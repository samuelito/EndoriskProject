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
    public class diseasesController : Controller
    {
        private endoriskContext db = new endoriskContext();

        // GET: diseases
        public ActionResult Index()
        {
            return View(db.diseases.ToList());
        }

        // GET: diseases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            disease disease = db.diseases.Find(id);
            if (disease == null)
            {
                return HttpNotFound();
            }
            return View(disease);
        }

        // GET: diseases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: diseases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDiseases,disease1,idRomeQuestion,criteria,comparedValue")] disease disease)
        {
            if (ModelState.IsValid)
            {
                db.diseases.Add(disease);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(disease);
        }

        // GET: diseases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            disease disease = db.diseases.Find(id);
            if (disease == null)
            {
                return HttpNotFound();
            }
            return View(disease);
        }

        // POST: diseases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDiseases,disease1,idRomeQuestion,criteria,comparedValue")] disease disease)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disease).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(disease);
        }

        // GET: diseases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            disease disease = db.diseases.Find(id);
            if (disease == null)
            {
                return HttpNotFound();
            }
            return View(disease);
        }

        // POST: diseases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            disease disease = db.diseases.Find(id);
            db.diseases.Remove(disease);
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
