using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class ModeratorsProfile
        : AutoMapper.Profile
        {
            public ModeratorsProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Moderators, Twitchbot.Common.Models.Domain.Models.ModeratorsReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.ModeratorsCreateModel, Twitchbot.Common.Models.Data.Entities.Moderators>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Moderators, Twitchbot.Common.Models.Domain.Models.ModeratorsUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.ModeratorsUpdateModel, Twitchbot.Common.Models.Data.Entities.Moderators>();

            }

        }
}