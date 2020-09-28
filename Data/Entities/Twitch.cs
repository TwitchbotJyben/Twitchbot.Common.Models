using Twitchbot.Common.Models.Definitions;

namespace Twitchbot.Common.Models.Data.Entities
{
    public partial class Twitch : IHaveIdentifier
    {
        public Twitch()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Token { get; set; }

        public int UserId { get; set; }

        public string ClientId { get; set; }

        public string RefreshToken { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Users UserUsers { get; set; }

        #endregion

    }
}