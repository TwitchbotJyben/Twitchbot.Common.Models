using Twitchbot.Models.Definitions;

namespace Twitchbot.Models.Data.Entities
{
    public partial class Commands : IHaveIdentifier
    {
        public Commands()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int? Timer { get; set; }

        public bool Activated { get; set; }

        public string Response { get; set; }

        public int UseId { get; set; }

        public string Name { get; set; }

        public int TypeId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual CommandsType TypeCommandsType { get; set; }

        public virtual Users UseUsers { get; set; }

        #endregion

    }
}
