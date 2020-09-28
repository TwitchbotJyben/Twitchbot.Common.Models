using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Queries
{
    public static partial class SpotifyExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Common.Models.Data.Entities.Spotify GetByKey(this IQueryable<Twitchbot.Common.Models.Data.Entities.Spotify> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Spotify> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Common.Models.Data.Entities.Spotify> GetByKeyAsync(this IQueryable<Twitchbot.Common.Models.Data.Entities.Spotify> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Spotify> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Common.Models.Data.Entities.Spotify>(task);
        }

        public static IQueryable<Twitchbot.Common.Models.Data.Entities.Spotify> ByUserId(this IQueryable<Twitchbot.Common.Models.Data.Entities.Spotify> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}