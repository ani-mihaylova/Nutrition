namespace CalendarOfNutrition.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Day
    {
        private ICollection<Recipe> recipes;

        public Day()
        {
            this.recipes = new List<Recipe>();
        }

        public int ID { get; set; }

        public ICollection<Recipe> Recipes
        {
            get { return this.recipes; }
            set { this.recipes = value; }
        }

    }
}
