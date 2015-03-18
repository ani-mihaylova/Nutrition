namespace CalendarOfNutrition.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Recipe
    {
        private ICollection<Tag> tags;

        public Recipe()
        {
            this.tags = new HashSet<Tag>();
        }

        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime? TimeToEat { get; set; }

        [Required]
        public string Ingredients { get; set; }
        

        [Required]
        public ICollection<Tag> Tags
        {
            get { return this.tags; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Tags in recipe cannot be null!");
                }

                this.tags = value;
            }
        }
    }
}
