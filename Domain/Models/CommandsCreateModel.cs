using System;
using System.Collections.Generic;

namespace Twitchbot.Models.Domain.Models
{
    public partial class CommandsCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int? Timer { get; set; }

        public bool Activated { get; set; }

        public string Response { get; set; }

        public int UseId { get; set; }

        public string Name { get; set; }

        public int TypeId { get; set; }

        #endregion

    }
}
