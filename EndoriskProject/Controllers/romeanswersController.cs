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
    public class romeanswersController : Controller
    {
        private endoriskContext db = new endoriskContext();

        // GET: romeanswers
        public ActionResult Index()
        {
            return View(db.romeanswers.ToList());
        }

        // GET: romeanswers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            romeanswer romeanswer = db.romeanswers.Find(id);
            if (romeanswer == null)
            {
                return HttpNotFound();
            }
            return View(romeanswer);
        }

        // GET: romeanswers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: romeanswers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idRomeQuiz,idRomeQuestion,answer")] romeanswer romeanswer)
        {
            if (ModelState.IsValid)
            {
                db.romeanswers.Add(romeanswer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(romeanswer);
        }

        // GET: romeanswers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            romeanswer romeanswer = db.romeanswers.Find(id);
            if (romeanswer == null)
            {
                return HttpNotFound();
            }
            return View(romeanswer);
        }

        // POST: romeanswers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idRomeQuiz,idRomeQuestion,answer")] romeanswer romeanswer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(romeanswer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(romeanswer);
        }

        // GET: romeanswers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            romeanswer romeanswer = db.romeanswers.Find(id);
            if (romeanswer == null)
            {
                return HttpNotFound();
            }
            return View(romeanswer);
        }

        // POST: romeanswers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            romeanswer romeanswer = db.romeanswers.Find(id);
            db.romeanswers.Remove(romeanswer);
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
