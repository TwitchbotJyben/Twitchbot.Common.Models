using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Queries
{
    public static partial class CommandsTypeExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Models.Data.Entities.CommandsType GetByKey(this IQueryable<Twitchbot.Models.Data.Entities.CommandsType> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.CommandsType> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Models.Data.Entities.CommandsType> GetByKeyAsync(this IQueryable<Twitchbot.Models.Data.Entities.CommandsType> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.CommandsType> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Models.Data.Entities.CommandsType>(task);
        }

        #endregion

    }
}
