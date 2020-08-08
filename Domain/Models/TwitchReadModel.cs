using System;
using System.Collections.Generic;

namespace Twitchbot.Models.Domain.Models
{
    public partial class TwitchReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Token { get; set; }

        public int UserId { get; set; }

        public string ClientId { get; set; }

        public string RefreshToken { get; set; }

        #endregion

    }
}
