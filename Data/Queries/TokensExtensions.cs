using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Queries
{
    public static partial class TokensExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Common.Models.Data.Entities.Tokens GetByKey(this IQueryable<Twitchbot.Common.Models.Data.Entities.Tokens> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Tokens> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Common.Models.Data.Entities.Tokens> GetByKeyAsync(this IQueryable<Twitchbot.Common.Models.Data.Entities.Tokens> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Common.Models.Data.Entities.Tokens> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Common.Models.Data.Entities.Tokens>(task);
        }

        #endregion

    }
}
