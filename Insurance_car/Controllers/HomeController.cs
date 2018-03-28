using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurance_car.Models;

namespace Insurance_car.Controllers
{
    public class HomeController : Controller
    {
        sugurtaEntities db = new sugurtaEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Calculator()
        {
            return View();
        }

        public ActionResult portfolio()
        {
            return View();
        }

        public ActionResult services()
        {
            return View();
        }
    }
}