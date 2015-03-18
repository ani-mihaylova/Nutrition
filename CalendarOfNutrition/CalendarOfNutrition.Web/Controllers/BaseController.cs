namespace CalendarOfNutrition.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using CalendarOfNutrition.Data;
    using CalendarOfNutrition.Models;
    using Microsoft.AspNet.Identity;

    public class BaseController : Controller
    {
        protected ICalendarOfNutritionData data;

        public BaseController()
        {
        }

        public BaseController(ICalendarOfNutritionData data)
            : this()
        {
            this.data = data;
        }

        protected User GetCurrentUser()
        {
            var currentUserId = this.User.Identity.GetUserId();
            var currentUser = this.data.Users.GetById(currentUserId);

            return currentUser;
        }
    }
}