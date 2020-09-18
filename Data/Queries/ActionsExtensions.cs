using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Queries
{
    public static partial class ActionsExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Models.Data.Entities.Actions GetByKey(this IQueryable<Twitchbot.Models.Data.Entities.Actions> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Actions> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Models.Data.Entities.Actions> GetByKeyAsync(this IQueryable<Twitchbot.Models.Data.Entities.Actions> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Actions> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Models.Data.Entities.Actions>(task);
        }

        #endregion

    }
}
