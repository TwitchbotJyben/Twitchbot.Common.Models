using Twitchbot.Common.Models.Definitions;

namespace Twitchbot.Common.Models.Data.Entities
{
    public partial class Settings : IHaveIdentifier
    {
        public Settings()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Activated { get; set; }

        public int UserId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Users UserUsers { get; set; }

        #endregion

    }
}