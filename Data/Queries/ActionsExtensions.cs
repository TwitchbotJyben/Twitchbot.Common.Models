using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Queries
{
    public static partial class ActionsExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Common.Models.Data.Entities.Actions GetByKey(this IQueryable<Twitchbot.Common.Models.Data.Entities.Actions> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Actions> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Common.Models.Data.Entities.Actions> GetByKeyAsync(this IQueryable<Twitchbot.Common.Models.Data.Entities.Actions> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Actions> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Common.Models.Data.Entities.Actions>(task);
        }

        #endregion

    }
}