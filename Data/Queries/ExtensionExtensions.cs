using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Queries
{
    public static partial class ExtensionExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Common.Models.Data.Entities.Extension GetByKey(this IQueryable<Twitchbot.Common.Models.Data.Entities.Extension> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Extension> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Common.Models.Data.Entities.Extension> GetByKeyAsync(this IQueryable<Twitchbot.Common.Models.Data.Entities.Extension> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Extension> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Common.Models.Data.Entities.Extension>(task);
        }

        public static IQueryable<Twitchbot.Common.Models.Data.Entities.Extension> ByUserId(this IQueryable<Twitchbot.Common.Models.Data.Entities.Extension> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}