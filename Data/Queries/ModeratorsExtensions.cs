using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Queries
{
    public static partial class ModeratorsExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Common.Models.Data.Entities.Moderators GetByKey(this IQueryable<Twitchbot.Common.Models.Data.Entities.Moderators> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Moderators> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Common.Models.Data.Entities.Moderators> GetByKeyAsync(this IQueryable<Twitchbot.Common.Models.Data.Entities.Moderators> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Moderators> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Common.Models.Data.Entities.Moderators>(task);
        }

        public static IQueryable<Twitchbot.Common.Models.Data.Entities.Moderators> ByUserId(this IQueryable<Twitchbot.Common.Models.Data.Entities.Moderators> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}