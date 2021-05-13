using System;
using System.ComponentModel;

namespace Twitchbot.Common.Models.Data.Enums
{
    public enum Roles
    {
        [Description("User")]
        User,
        [Description("Moderator")]
        Moderator,
        [Description("App")]
        App,
        [Description("Admin")]
        Admin
    }
}
