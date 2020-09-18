using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Queries
{
    public static partial class ExtensionExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Models.Data.Entities.Extension GetByKey(this IQueryable<Twitchbot.Models.Data.Entities.Extension> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Extension> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Models.Data.Entities.Extension> GetByKeyAsync(this IQueryable<Twitchbot.Models.Data.Entities.Extension> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Extension> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Models.Data.Entities.Extension>(task);
        }

        public static IQueryable<Twitchbot.Models.Data.Entities.Extension> ByUserId(this IQueryable<Twitchbot.Models.Data.Entities.Extension> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
