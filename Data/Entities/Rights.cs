using System;
using System.Collections.Generic;

namespace Twitchbot.Models.Data.Entities
{
    public partial class Rights
    {
        public Rights()
        {
            #region Generated Constructor
            RightUsers = new HashSet<Users>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Description { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Users> RightUsers { get; set; }

        #endregion

    }
}
