using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scheduler.Models;

namespace Scheduler.Controllers
{
    public class HomeController : Controller
    {
        SchedulerContext _db = new SchedulerContext();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            //var anEvent = new Event()
            //    {
            //        PersonId = 1,
            //        StartDate = new DateTime(2013, 12, 18, 13, 0, 0),
            //        EndDate = new DateTime(2013, 12, 18, 14, 0, 0),
            //        CreatedBy = 1,
            //        CreatedOn = DateTime.Now
            //    };

            //_db.Events.Add(anEvent);
            //_db.SaveChanges();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
