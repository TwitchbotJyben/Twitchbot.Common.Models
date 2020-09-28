using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class SpotifyProfile
        : AutoMapper.Profile
        {
            public SpotifyProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Spotify, Twitchbot.Common.Models.Domain.Models.SpotifyReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.SpotifyCreateModel, Twitchbot.Common.Models.Data.Entities.Spotify>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Spotify, Twitchbot.Common.Models.Domain.Models.SpotifyUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.SpotifyUpdateModel, Twitchbot.Common.Models.Data.Entities.Spotify>();

            }

        }
}