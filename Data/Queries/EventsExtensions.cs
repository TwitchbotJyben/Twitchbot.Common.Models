using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Queries
{
    public static partial class EventsExtensions
    {
        #region Generated Extensions
        public static IQueryable<Twitchbot.Models.Data.Entities.Events> ByActionId(this IQueryable<Twitchbot.Models.Data.Entities.Events> queryable, int actionId)
        {
            return queryable.Where(q => q.ActionId == actionId);
        }

        public static IQueryable<Twitchbot.Models.Data.Entities.Events> ByCategoryId(this IQueryable<Twitchbot.Models.Data.Entities.Events> queryable, int categoryId)
        {
            return queryable.Where(q => q.CategoryId == categoryId);
        }

        public static Twitchbot.Models.Data.Entities.Events GetByKey(this IQueryable<Twitchbot.Models.Data.Entities.Events> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Events> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Models.Data.Entities.Events> GetByKeyAsync(this IQueryable<Twitchbot.Models.Data.Entities.Events> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Events> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Models.Data.Entities.Events>(task);
        }

        public static IQueryable<Twitchbot.Models.Data.Entities.Events> ByUserId(this IQueryable<Twitchbot.Models.Data.Entities.Events> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
