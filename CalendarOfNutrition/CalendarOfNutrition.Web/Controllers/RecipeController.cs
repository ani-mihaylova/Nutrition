namespace CalendarOfNutrition.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using CalendarOfNutrition.Web.Controllers;
    using CalendarOfNutrition.Data;
    using AutoMapper.QueryableExtensions;
    using CalendarOfNutrition.Web.Models;
    using CalendarOfNutrition.Web.ViewModels.RecipeModels;

    public class RecipeController : BaseController
    {
        public RecipeController(ICalendarOfNutritionData data)
            : base(data)
        {

        }
        
        //Get 
        [HttpGet]
        public ActionResult CreateRecipe()
        {
            var newRecipe = new CreateRecipeViewModel();
            var tagNamesList = new List<SelectListItem>();
            var allTags = this.data.Tags.All();

            foreach (var tag in allTags)
            {
                var newItem = new SelectListItem()
                {
                    Text = tag.Name,
                    Value = tag.ID.ToString()
                };

                tagNamesList.Add(newItem);
            }

            newRecipe.Tags = tagNamesList;

            return this.View("Create",newRecipe);
        }
    }
}