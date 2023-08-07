using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_DotNet_MVC.Models;

namespace WebApplication_DotNet_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Dictionary<string, string> genders = new Dictionary<string, string>
            {
                { "Male", "1" },
                { "Female", "2" },
                { "Other", "3" }
            };

            ViewBag.Genders = genders;

            ViewData["Genders"] = genders;

            TempData["Genders"] = genders;

            return View("Index", new Employee());
        }

        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            if (ModelState.IsValid)
            {

            }

            var viewBag = ViewBag.Genders;
            var viewData = ViewData["Genders"];
            var tempData = TempData.Peek("Genders");
            TempData.Keep("Genders");

            return View();
        }

        public ActionResult Contact()
        {
            var tempData = TempData.Peek("Genders");
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}