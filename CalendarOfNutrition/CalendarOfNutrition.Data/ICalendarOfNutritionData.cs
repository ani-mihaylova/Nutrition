using CalendarOfNutrition.Data.Repositories;
using CalendarOfNutrition.Models;
namespace CalendarOfNutrition.Data
{
    public interface ICalendarOfNutritionData
    {
        IApplicationDbContext Context { get; }

        IGenericRepository<Recipe> Recipes { get; }

        IGenericRepository<Tag> Tags { get; }

        IGenericRepository<Diet> Diet { get; }

        IGenericRepository<User> Users { get; }

        int SaveChanges();

        void Dispose();
    }
}
