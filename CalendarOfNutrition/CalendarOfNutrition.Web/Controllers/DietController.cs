using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalendarOfNutrition.Web.Controllers
{
    public class DietController : Controller
    {
        // GET: Diet
        public ActionResult CreateDiet()
        {
            return View("Create");
        }
    }
}