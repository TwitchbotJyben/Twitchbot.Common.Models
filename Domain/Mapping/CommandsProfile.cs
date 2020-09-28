using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class CommandsProfile
        : AutoMapper.Profile
        {
            public CommandsProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Commands, Twitchbot.Common.Models.Domain.Models.CommandsReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.CommandsCreateModel, Twitchbot.Common.Models.Data.Entities.Commands>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Commands, Twitchbot.Common.Models.Domain.Models.CommandsUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.CommandsUpdateModel, Twitchbot.Common.Models.Data.Entities.Commands>();

            }

        }
}