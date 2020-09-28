using System;
using System.Collections.Generic;
using Twitchbot.Common.Models.Definitions;

namespace Twitchbot.Common.Models.Data.Entities
{
    public partial class Spotify : IHaveIdentifier
    {
        public Spotify()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Token { get; set; }

        public string RefreshToken { get; set; }

        public int UserId { get; set; }

        public int? ExpiresIn { get; set; }

        public DateTime? Time { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Users UserUsers { get; set; }

        #endregion

    }
}