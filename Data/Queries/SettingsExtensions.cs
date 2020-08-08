using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Queries
{
    public static partial class SettingsExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Models.Data.Entities.Settings GetByKey(this IQueryable<Twitchbot.Models.Data.Entities.Settings> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Settings> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Models.Data.Entities.Settings> GetByKeyAsync(this IQueryable<Twitchbot.Models.Data.Entities.Settings> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Settings> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Models.Data.Entities.Settings>(task);
        }

        public static IQueryable<Twitchbot.Models.Data.Entities.Settings> ByUserId(this IQueryable<Twitchbot.Models.Data.Entities.Settings> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
