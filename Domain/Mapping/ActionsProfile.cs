using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class ActionsProfile
        : AutoMapper.Profile
        {
            public ActionsProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Actions, Twitchbot.Common.Models.Domain.Models.ActionsReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.ActionsCreateModel, Twitchbot.Common.Models.Data.Entities.Actions>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Actions, Twitchbot.Common.Models.Domain.Models.ActionsUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.ActionsUpdateModel, Twitchbot.Common.Models.Data.Entities.Actions>();

            }

        }
}