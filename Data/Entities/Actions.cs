using System;
using System.Collections.Generic;
using Twitchbot.Common.Models.Definitions;

namespace Twitchbot.Common.Models.Data.Entities
{
    public partial class Actions : IHaveIdentifier
    {
        public Actions()
        {
            #region Generated Constructor
            ActionEvents = new HashSet<Events>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Events> ActionEvents { get; set; }

        #endregion

    }
}