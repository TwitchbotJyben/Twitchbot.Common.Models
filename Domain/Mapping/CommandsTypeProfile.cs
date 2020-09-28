using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class CommandsTypeProfile
        : AutoMapper.Profile
        {
            public CommandsTypeProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.CommandsType, Twitchbot.Common.Models.Domain.Models.CommandsTypeReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.CommandsTypeCreateModel, Twitchbot.Common.Models.Data.Entities.CommandsType>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.CommandsType, Twitchbot.Common.Models.Domain.Models.CommandsTypeUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.CommandsTypeUpdateModel, Twitchbot.Common.Models.Data.Entities.CommandsType>();

            }

        }
}