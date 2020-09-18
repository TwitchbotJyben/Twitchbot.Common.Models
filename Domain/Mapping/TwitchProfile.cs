using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class TwitchProfile
        : AutoMapper.Profile
    {
        public TwitchProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Twitch, Twitchbot.Models.Domain.Models.TwitchReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.TwitchCreateModel, Twitchbot.Models.Data.Entities.Twitch>();

            CreateMap<Twitchbot.Models.Data.Entities.Twitch, Twitchbot.Models.Domain.Models.TwitchUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.TwitchUpdateModel, Twitchbot.Models.Data.Entities.Twitch>();

        }

    }
}
