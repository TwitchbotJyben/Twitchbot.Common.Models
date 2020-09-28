using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class RightsProfile
        : AutoMapper.Profile
        {
            public RightsProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Rights, Twitchbot.Common.Models.Domain.Models.RightsReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.RightsCreateModel, Twitchbot.Common.Models.Data.Entities.Rights>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Rights, Twitchbot.Common.Models.Domain.Models.RightsUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.RightsUpdateModel, Twitchbot.Common.Models.Data.Entities.Rights>();

            }

        }
}