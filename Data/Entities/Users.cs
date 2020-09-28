using System.Collections.Generic;
using Twitchbot.Common.Models.Definitions;

namespace Twitchbot.Common.Models.Data.Entities
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
            UserSpotifies = new HashSet<Spotify>();
            UserTwitches = new HashSet<Twitch>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int? RightId { get; set; }

        public string Name { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Rights RightRights { get; set; }

        public virtual ICollection<Commands> UseCommands { get; set; }

        public virtual ICollection<Events> UserEvents { get; set; }

        public virtual ICollection<Extension> UserExtensions { get; set; }

        public virtual ICollection<Moderators> UserModerators { get; set; }

        public virtual ICollection<Settings> UserSettings { get; set; }

        public virtual ICollection<Spotify> UserSpotifies { get; set; }

        public virtual ICollection<Twitch> UserTwitches { get; set; }

        #endregion

    }
}