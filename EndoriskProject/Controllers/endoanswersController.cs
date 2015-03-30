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
    public class endoanswersController : Controller
    {
        private endoriskContext db = new endoriskContext();

        // GET: endoanswers
        public ActionResult Index()
        {
            return View(db.endoanswers.ToList());
        }

        // GET: endoanswers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            endoanswer endoanswer = db.endoanswers.Find(id);
            if (endoanswer == null)
            {
                return HttpNotFound();
            }
            return View(endoanswer);
        }

        // GET: endoanswers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: endoanswers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idQuiz,idQuestion,answer")] endoanswer endoanswer)
        {
            if (ModelState.IsValid)
            {
                db.endoanswers.Add(endoanswer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(endoanswer);
        }

        // GET: endoanswers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            endoanswer endoanswer = db.endoanswers.Find(id);
            if (endoanswer == null)
            {
                return HttpNotFound();
            }
            return View(endoanswer);
        }

        // POST: endoanswers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idQuiz,idQuestion,answer")] endoanswer endoanswer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(endoanswer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(endoanswer);
        }

        // GET: endoanswers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            endoanswer endoanswer = db.endoanswers.Find(id);
            if (endoanswer == null)
            {
                return HttpNotFound();
            }
            return View(endoanswer);
        }

        // POST: endoanswers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            endoanswer endoanswer = db.endoanswers.Find(id);
            db.endoanswers.Remove(endoanswer);
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
