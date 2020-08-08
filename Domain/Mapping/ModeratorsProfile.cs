using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class ModeratorsProfile
        : AutoMapper.Profile
    {
        public ModeratorsProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Moderators, Twitchbot.Models.Domain.Models.ModeratorsReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.ModeratorsCreateModel, Twitchbot.Models.Data.Entities.Moderators>();

            CreateMap<Twitchbot.Models.Data.Entities.Moderators, Twitchbot.Models.Domain.Models.ModeratorsUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.ModeratorsUpdateModel, Twitchbot.Models.Data.Entities.Moderators>();

        }

    }
}
