using Twitchbot.Models.Definitions;

namespace Twitchbot.Models.Data.Entities
{
    public partial class Extension : IHaveIdentifier
    {
        public Extension()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public int UserId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Users UserUsers { get; set; }

        #endregion

    }
}
