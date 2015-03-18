namespace CalendarOfNutrition.Web.ViewModels.RecipeModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using AutoMapper;
    using CalendarOfNutrition.Models;
    using CalendarOfNutrition.Web.Infrastracture.Mapping;

    public class MainPageRecipeViewModel : IMapFrom<Recipe>, IHaveCustomMappings
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Recipe, MainPageRecipeViewModel>()
                .ForMember(m => m.Tags, opt => opt.MapFrom(t => t.Tags))
                .ReverseMap();
        }
    }
}