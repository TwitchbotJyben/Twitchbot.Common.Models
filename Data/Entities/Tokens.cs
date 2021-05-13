using System;
using System.Collections.Generic;

namespace Twitchbot.Common.Models.Data.Entities
{
    public partial class Tokens
    {
        public Tokens()
        {
            #region Generated Constructor
            TokenUsers = new HashSet<Users>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Token { get; set; }

        public DateTime Created { get; set; }

        public string CreatedByIp { get; set; }

        public DateTime Expires { get; set; }

        public string ReplacedByToken { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Users> TokenUsers { get; set; }

        #endregion

    }
}
