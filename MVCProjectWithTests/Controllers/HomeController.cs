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
            ViewBag.Message = "Not muuy Your   application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Not Yourdfccd   d contact page.";

            return View();
        }
    }
}