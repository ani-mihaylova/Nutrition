namespace CalendarOfNutrition.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CalendarOfNutrition.Data.Repositories;
    using CalendarOfNutrition.Models;

    public class CalendarOfNutritionData : ICalendarOfNutritionData
    {
        private readonly IApplicationDbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public CalendarOfNutritionData(IApplicationDbContext context)
        {
            this.context = context;
        }
        public IApplicationDbContext Context
        {
            get { return this.context; }
        }

        public IGenericRepository<Recipe> Recipes
        {
            get { return this.GetRepository<Recipe>(); }
        }

        public IGenericRepository<Tag> Tags
        {
            get { return this.GetRepository<Tag>(); }
        }

        public IGenericRepository<Diet> Diet
        {
            get { return this.GetRepository<Diet>(); }
        }

        public IGenericRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);
                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeof(T)];
        }
    }
}
