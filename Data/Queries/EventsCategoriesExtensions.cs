using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Queries
{
    public static partial class EventsCategoriesExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Models.Data.Entities.EventsCategories GetByKey(this IQueryable<Twitchbot.Models.Data.Entities.EventsCategories> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.EventsCategories> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Models.Data.Entities.EventsCategories> GetByKeyAsync(this IQueryable<Twitchbot.Models.Data.Entities.EventsCategories> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.EventsCategories> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Models.Data.Entities.EventsCategories>(task);
        }

        #endregion

    }
}
