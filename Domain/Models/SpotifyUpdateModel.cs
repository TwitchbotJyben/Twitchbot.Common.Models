using System;
using System.Collections.Generic;

namespace Twitchbot.Common.Models.Domain.Models
{
    public partial class SpotifyUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Token { get; set; }

        public string RefreshToken { get; set; }

        public int UserId { get; set; }

        public int? ExpiresIn { get; set; }

        public DateTime? Time { get; set; }

        #endregion

    }
}