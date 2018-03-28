using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurance_car.Models;

namespace Insurance_car.Controllers
{
    public class AdminController : Controller
    {
        sugurtaEntities db = new sugurtaEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult charts()
        {
            return View();
        }
        public ActionResult elements()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult panels()
        {
            return View();
        }
        public ActionResult widgets()
        {
            return View();
        }
    }
}