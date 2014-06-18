using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is an attempt at deploying an asp.net site to ~the cloud~ oohhhhhhhh";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please don't contact me";

            return View();
        }
    }
}