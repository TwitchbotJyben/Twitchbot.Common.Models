using System;
using System.ComponentModel;

namespace Twitchbot.Common.Models.Data.Enums
{
    public enum Roles
    {
        [Description("Admin")]
        Admin,
        [Description("Moderator")]
        Moderator,
        [Description("App")]
        App,
        [Description("User")]
        User
    }
}
