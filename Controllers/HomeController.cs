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
            Employee employee = new Employee();


            ViewBag.Message = "ViewBag - From Index Action";
            ViewData["Message"] = employee.ListOfGender;

            TempData["Message"] = "TempData - From Index Action ";

            return View("Index", employee);
        }

        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            if (ModelState.IsValid)
            {

            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(int id)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}