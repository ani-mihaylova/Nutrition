namespace CalendarOfNutrition.Web.ViewModels.RecipeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using CalendarOfNutrition.Models;
    using CalendarOfNutrition.Web.Infrastracture.Mapping;

    public class CreateRecipeViewModel : IMapFrom<Recipe>
    {
        [Required]
        [UIHint("String")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [UIHint("Multiline")]
        public string Description { get; set; }

        public DateTime? TimeToEat { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [UIHint("Multiline")]
        public string Ingredients { get; set; }

        [Required]
        public ICollection<SelectListItem> Tags { get; set; }
    }
}