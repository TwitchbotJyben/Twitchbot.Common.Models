using System;
using Twitchbot.Models.Definitions;

namespace Twitchbot.Models.Data.Entities
{
    public partial class Events : IHaveIdentifier
    {
        public Events()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string UserName { get; set; }

        public DateTime Time { get; set; }

        public string Object { get; set; }

        public int ActionId { get; set; }

        public int CategoryId { get; set; }

        public int UserId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Actions ActionActions { get; set; }

        public virtual EventsCategories CategoryEventsCategories { get; set; }

        public virtual Users UserUsers { get; set; }

        #endregion

    }
}
