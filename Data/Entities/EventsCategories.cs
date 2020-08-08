using System.Collections.Generic;
using Twitchbot.Models.Definitions;

namespace Twitchbot.Models.Data.Entities
{
    public partial class EventsCategories : IHaveIdentifier
    {
        public EventsCategories()
        {
            #region Generated Constructor
            CategoryEvents = new HashSet<Events>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Events> CategoryEvents { get; set; }

        #endregion

    }
}
