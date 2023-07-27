using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace form.Controllers
{
    public class HomeController : Controller
    {
        string EmailPattern = @"^[\w.-]+@[a-zA-Z\d.-]+\.[a-zA-Z]{2,}$";

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Fullname, string Age, string Email)
        {
            if (string.IsNullOrEmpty(Fullname))
            {
                ModelState.AddModelError("Fullname", "Fullname is required");
                ViewData["Fullname Error"] = "*";
                
            }
            if (string.IsNullOrEmpty(Age))
            {
                ModelState.AddModelError("Age", "Age is required!!");
                ViewData["Age Error"] = "*";
               
            }
            if (string.IsNullOrEmpty(Email))
            {
                ModelState.AddModelError("Email", "Email is required!!");
                ViewData["Email Error"] = "*";
                
            }
            if (!Regex.IsMatch(Email, EmailPattern))
            {
                ModelState.AddModelError("Email", "Invalid Email!!");
                ViewData["Email Error"] = "*";
            }

            if (ModelState.IsValid)
            {
                ViewData["SuccessMessagwe"] = "<script>alert('Data has been submitted !!')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}