using System.Collections.Generic;
using Twitchbot.Models.Definitions;

namespace Twitchbot.Models.Data.Entities
{
    public partial class Users : IHaveIdentifier
    {
        public Users()
        {
            #region Generated Constructor
            UseCommands = new HashSet<Commands>();
            UserEvents = new HashSet<Events>();
            UserExtensions = new HashSet<Extension>();
            UserModerators = new HashSet<Moderators>();
            UserSettings = new HashSet<Settings>();
            UserTwitches = new HashSet<Twitch>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Commands> UseCommands { get; set; }

        public virtual ICollection<Events> UserEvents { get; set; }

        public virtual ICollection<Extension> UserExtensions { get; set; }

        public virtual ICollection<Moderators> UserModerators { get; set; }

        public virtual ICollection<Settings> UserSettings { get; set; }

        public virtual ICollection<Twitch> UserTwitches { get; set; }

        #endregion

    }
}
