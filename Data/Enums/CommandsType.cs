using System.ComponentModel;

namespace Twitchbot.Models.Data.Enums
{
    public enum CommandsType
    {
        None,
        [Description("Response")]
        Response,
        [Description("Automatic")]
        Automatic,
        [Description("Spotify")]
        Spotify,
        [Description("Playlist")]
        Playlist,
        [Description("Uptime")]
        Uptime,
        [Description("Mystery")]
        Mystery
    }
}