namespace CalendarOfNutrition.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CalendarOfNutrition.Models;

    public class Diet
    {
        private ICollection<Day> days;

        public Diet()
        {
            this.days = new List<Day>();
        }

        public int ID { get; set; }

        public int? NumberOfDays { get; set; }

        public ICollection<Day> Days
        {
            get { return this.days; }
            set { this.days = value; }

        }
    }
}
