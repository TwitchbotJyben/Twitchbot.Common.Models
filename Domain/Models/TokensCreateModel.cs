using System;
using System.Collections.Generic;

namespace Twitchbot.Common.Models.Domain.Models
{
    public partial class TokensCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Token { get; set; }

        public DateTime Created { get; set; }

        public string CreatedByIp { get; set; }

        public DateTime Expires { get; set; }

        public string ReplacedByToken { get; set; }

        #endregion

    }
}
