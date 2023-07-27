using Addition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Addition.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Class1 c)
        {
            int num1 = c.num1;
            int num2 = c.num2;
            int result=num1 + num2;
            ViewBag.result=result;
            return View();
        }
    }
}