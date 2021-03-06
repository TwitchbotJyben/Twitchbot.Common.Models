using System;
using System.Collections.Generic;

namespace Twitchbot.Common.Models.Domain.Models
{
    public partial class TwitchUpdateModel
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