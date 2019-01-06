using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterfaceDotnet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Fried()
        {
            ViewBag.Message = "Choose your menu.";

            return View();
        }

        public ActionResult Mee()
        {
            ViewBag.Message = "Choose your menu.";

            return View();
        }

        public ActionResult Soup()
        {
            ViewBag.Message = "Choose your menu.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Share your feedback by contacting us here";
            return View();
        }
    }
}