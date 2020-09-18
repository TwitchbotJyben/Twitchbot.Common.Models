using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Queries
{
    public static partial class CommandsExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Models.Data.Entities.Commands GetByKey(this IQueryable<Twitchbot.Models.Data.Entities.Commands> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Commands> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Models.Data.Entities.Commands> GetByKeyAsync(this IQueryable<Twitchbot.Models.Data.Entities.Commands> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Commands> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Models.Data.Entities.Commands>(task);
        }

        public static IQueryable<Twitchbot.Models.Data.Entities.Commands> ByTypeId(this IQueryable<Twitchbot.Models.Data.Entities.Commands> queryable, int typeId)
        {
            return queryable.Where(q => q.TypeId == typeId);
        }

        public static IQueryable<Twitchbot.Models.Data.Entities.Commands> ByUseId(this IQueryable<Twitchbot.Models.Data.Entities.Commands> queryable, int useId)
        {
            return queryable.Where(q => q.UseId == useId);
        }

        #endregion

    }
}
