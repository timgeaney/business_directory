using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA3_D10120047.Models;

namespace CA3_D10120047.Controllers
{
    public class BusinessController : Controller
    {
        private CA3_D10120047Db db = new CA3_D10120047Db();

        //
        // GET: /Business/

        public ActionResult Index()
        {
            return View(db.Businesses.ToList());
        }

        //
        // GET: /Business/Details/5

       

        //
        // GET: /Business/Create
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Business/Create

        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]// to stop cross site request forgery CSRF
        public ActionResult Create(Business business)
        {
            if (ModelState.IsValid)
            {
                db.Businesses.Add(business);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(business);
        }

        //
        // GET: /Business/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Business business = db.Businesses.Find(id);
            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        //
        // POST: /Business/Edit/5

        [HttpPost]
        public ActionResult Edit(Business business)
        {
            if (ModelState.IsValid)
            {
                db.Entry(business).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(business);
        }

        //
        // GET: /Business/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Business business = db.Businesses.Find(id);
            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        //
        // POST: /Business/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Business business = db.Businesses.Find(id);
            db.Businesses.Remove(business);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}