using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class SpotifyProfile
        : AutoMapper.Profile
    {
        public SpotifyProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Spotify, Twitchbot.Models.Domain.Models.SpotifyReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.SpotifyCreateModel, Twitchbot.Models.Data.Entities.Spotify>();

            CreateMap<Twitchbot.Models.Data.Entities.Spotify, Twitchbot.Models.Domain.Models.SpotifyUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.SpotifyUpdateModel, Twitchbot.Models.Data.Entities.Spotify>();

        }

    }
}
