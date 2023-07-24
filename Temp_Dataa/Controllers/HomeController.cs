using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Temp_Dataa.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["var1"] ="THis is MY VIEW DATA";
            ViewBag.var2= "THis is MY VIEW Bag";
            TempData["var3"]= "THis is MY Temp DATA";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}