using System;
using System.Collections.Generic;

namespace Twitchbot.Models.Domain.Models
{
    public partial class SettingsReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Activated { get; set; }

        public int UserId { get; set; }

        #endregion

    }
}
