using System;
using System.Collections.Generic;

namespace Twitchbot.Models.Domain.Models
{
    public partial class SpotifyReadModel
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
