using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace Ultimate_Analysis_Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UltimateDBEntities ultimate = new UltimateDBEntities();
            return View(ultimate.StatsTests.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}