using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class CommandsProfile
        : AutoMapper.Profile
    {
        public CommandsProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Commands, Twitchbot.Models.Domain.Models.CommandsReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.CommandsCreateModel, Twitchbot.Models.Data.Entities.Commands>();

            CreateMap<Twitchbot.Models.Data.Entities.Commands, Twitchbot.Models.Domain.Models.CommandsUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.CommandsUpdateModel, Twitchbot.Models.Data.Entities.Commands>();

        }

    }
}
