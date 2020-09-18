using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Queries
{
    public static partial class UsersExtensions
    {
        #region Generated Extensions
        public static Twitchbot.Models.Data.Entities.Users GetByKey(this IQueryable<Twitchbot.Models.Data.Entities.Users> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Users> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Twitchbot.Models.Data.Entities.Users> GetByKeyAsync(this IQueryable<Twitchbot.Models.Data.Entities.Users> queryable, int id)
        {
            if (queryable is DbSet<Twitchbot.Models.Data.Entities.Users> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Twitchbot.Models.Data.Entities.Users>(task);
        }

        public static IQueryable<Twitchbot.Models.Data.Entities.Users> ByRightId(this IQueryable<Twitchbot.Models.Data.Entities.Users> queryable, int? rightId)
        {
            return queryable.Where(q => (q.RightId == rightId || (rightId == null && q.RightId == null)));
        }

        #endregion

    }
}
