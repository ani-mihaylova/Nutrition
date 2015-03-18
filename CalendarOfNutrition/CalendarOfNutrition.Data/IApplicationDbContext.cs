namespace CalendarOfNutrition.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using CalendarOfNutrition.Models;

    public interface IApplicationDbContext
    {
        IDbSet<Recipe> Recipes { get; set; }

        IDbSet<Tag> Tags { get; set; }

        IDbSet<Diet> Diets { get; set; }

        IDbSet<User> Users { get; set; }

        int SaveChanges();

        void Dispose();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
