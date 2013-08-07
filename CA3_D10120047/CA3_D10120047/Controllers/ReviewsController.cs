using CA3_D10120047.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA3_D10120047.Controllers
{
    public class ReviewsController : Controller
    {


        CA3_D10120047Db _db = new CA3_D10120047Db();
        //
        // GET: /Reviews/

        public ActionResult Index([Bind(Prefix="id")] int businessId)
        {
            var business = _db.Businesses.Find(businessId);
            if (business != null)
            {
                return View(business);
            }
            return HttpNotFound();
           
        }

      

        [HttpGet]
        public ActionResult Create(int businessId)
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(BusinessReview review)
        {
            //if this is false something went wrong with model
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.BusinessId });
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(BusinessReview review)
        {
            //if this is false something went wrong with model
            if (ModelState.IsValid)
            {
                //This telle EF thet here is a review that I need you to track so you can make changes in DB
                //for review. Its not a new review so don't insert it into 
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.BusinessId });
            }
            return View(review);
        }



        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }

    }
}
