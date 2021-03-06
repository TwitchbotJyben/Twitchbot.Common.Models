using System.Collections.Generic;
using Twitchbot.Common.Models.Definitions;

namespace Twitchbot.Common.Models.Data.Entities
{
    public partial class CommandsType : IHaveIdentifier
    {
        public CommandsType()
        {
            #region Generated Constructor
            TypeCommands = new HashSet<Commands>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Commands> TypeCommands { get; set; }

        #endregion

    }
}