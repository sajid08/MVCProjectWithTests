using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjectWithTests.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Not my Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Not Your contact page.";

            return View();
        }
    }
}