using System.Collections.Generic;
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

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RenderGrid()
        {
            List<Employee> list = new List<Employee>();

            list.Add(new Employee() { Id = 1, FirstName = "Jason", LastName = "Mark", Gender = 1 });
            list.Add(new Employee() { Id = 2, FirstName = "New", LastName = "Data", Gender = 1 });
            list.Add(new Employee() { Id = 3, FirstName = "Steven", LastName = "Smith", Gender = 2 });
            list.Add(new Employee() { Id = 4, FirstName = "Mark", LastName = "Wood", Gender = 2 });

            return PartialView("_GridPartial", list);
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