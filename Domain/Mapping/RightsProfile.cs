using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class RightsProfile
        : AutoMapper.Profile
    {
        public RightsProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Rights, Twitchbot.Models.Domain.Models.RightsReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.RightsCreateModel, Twitchbot.Models.Data.Entities.Rights>();

            CreateMap<Twitchbot.Models.Data.Entities.Rights, Twitchbot.Models.Domain.Models.RightsUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.RightsUpdateModel, Twitchbot.Models.Data.Entities.Rights>();

        }

    }
}
