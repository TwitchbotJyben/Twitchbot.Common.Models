using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Queries
{
    public static partial class SettingsExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Common.Models.Data.Entities.Settings GetByKey(this IQueryable<Twitchbot.Common.Models.Data.Entities.Settings> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Settings> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Common.Models.Data.Entities.Settings> GetByKeyAsync(this IQueryable<Twitchbot.Common.Models.Data.Entities.Settings> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Settings> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Common.Models.Data.Entities.Settings>(task);
        }

        public static IQueryable<Twitchbot.Common.Models.Data.Entities.Settings> ByUserId(this IQueryable<Twitchbot.Common.Models.Data.Entities.Settings> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}