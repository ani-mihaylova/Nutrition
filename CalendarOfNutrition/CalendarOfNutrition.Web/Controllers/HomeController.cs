namespace CalendarOfNutrition.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using CalendarOfNutrition.Data;
    using CalendarOfNutrition.Web.ViewModels.RecipeModels;


    public class HomeController : BaseController
    {

        public HomeController(ICalendarOfNutritionData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            //var recipes = this.data.Recipes
            //    .All()
            //    .Project()
            //    .To<MainPageRecipeViewModel>()
            //    .ToList();

            return View("Index");
        }
    }
}