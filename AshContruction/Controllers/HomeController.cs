using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AshContruction.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Project()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Project_Detail()
        {
            return View();
        }
        public ActionResult services_details()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Element ()
        {
            return View();
        }
        public ActionResult single_blog()
        {
            return View();
        }
    }
}