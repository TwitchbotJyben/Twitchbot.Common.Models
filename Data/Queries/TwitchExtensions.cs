using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Queries
{
    public static partial class TwitchExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Models.Data.Entities.Twitch GetByKey(this IQueryable<Twitchbot.Models.Data.Entities.Twitch> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Twitch> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Models.Data.Entities.Twitch> GetByKeyAsync(this IQueryable<Twitchbot.Models.Data.Entities.Twitch> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Twitch> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Models.Data.Entities.Twitch>(task);
        }

        public static IQueryable<Twitchbot.Models.Data.Entities.Twitch> ByUserId(this IQueryable<Twitchbot.Models.Data.Entities.Twitch> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
