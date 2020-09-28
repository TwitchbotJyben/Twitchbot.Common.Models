using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class TwitchProfile
        : AutoMapper.Profile
        {
            public TwitchProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Twitch, Twitchbot.Common.Models.Domain.Models.TwitchReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.TwitchCreateModel, Twitchbot.Common.Models.Data.Entities.Twitch>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Twitch, Twitchbot.Common.Models.Domain.Models.TwitchUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.TwitchUpdateModel, Twitchbot.Common.Models.Data.Entities.Twitch>();

            }

        }
}