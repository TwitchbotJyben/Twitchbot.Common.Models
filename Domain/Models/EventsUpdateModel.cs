using System;
using System.Collections.Generic;

namespace Twitchbot.Common.Models.Domain.Models
{
    public partial class EventsUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string UserName { get; set; }

        public DateTime Time { get; set; }

        public string Object { get; set; }

        public int ActionId { get; set; }

        public int CategoryId { get; set; }

        public int UserId { get; set; }

        #endregion

    }
}