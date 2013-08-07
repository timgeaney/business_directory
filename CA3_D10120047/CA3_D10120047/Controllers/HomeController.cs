using CA3_D10120047.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Web.UI;
using System.Configuration;

namespace CA3_D10120047.Controllers
{
    
    public class HomeController : Controller
    {
        ICA3_D10120047Db _db;

        public HomeController()
        {
            _db = new CA3_D10120047Db();
        }

        public HomeController(ICA3_D10120047Db db)
        {
            _db = db;
                
        }

        public ActionResult Autocomplete(string term)
        {
            var model =
                _db.Query<Business>()
                .Where(b => b.Name.StartsWith(term))
                .Take(10)
                .Select(b => new
                {
                    label = b.Name
                });

            return Json(model, JsonRequestBehavior.AllowGet);
        }


       
       
        [OutputCache(Duration = 360, VaryByHeader = "X-Requested-With", Location = OutputCacheLocation.Server)]
        public ActionResult Index(string searchTerm = null, int page = 1)
        {
            var model =
                 _db.Query<Business>()
                    .OrderByDescending(b => b.Reviews.Average(review => review.Rating))
                    .Where(b => searchTerm == null || b.Name.StartsWith(searchTerm))
                    .Select(b => new BusinessListViewModel
                    {
                        Id = b.Id,
                        Name = b.Name,
                        City = b.City,
                        Country = b.Country,
                        CountOfReviews = b.Reviews.Count(),
                        AverageRating = (int)b.Reviews.Average(review => review.Rating)
                       
                    }).ToPagedList(page, 10);

            



            ViewBag.MailServer = ConfigurationManager.AppSettings["MailServer"];

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Business", model);
            }
           

            return View(model);
        }

        //make user sign in before getteing access
        //[Authorize]
        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Tim";
            model.Location = "dublin";


            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
