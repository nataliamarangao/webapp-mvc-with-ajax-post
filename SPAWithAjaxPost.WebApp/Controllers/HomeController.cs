using SPAWithAjaxPost.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAWithAjaxPost.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxPostCall(Employee employeeData)
        {
            Employee employee = new Employee
            {
                Name = employeeData.Name,
                Designation = employeeData.Designation,
                Location = employeeData.Location
            };
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}