using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class CommandsTypeProfile
        : AutoMapper.Profile
    {
        public CommandsTypeProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.CommandsType, Twitchbot.Models.Domain.Models.CommandsTypeReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.CommandsTypeCreateModel, Twitchbot.Models.Data.Entities.CommandsType>();

            CreateMap<Twitchbot.Models.Data.Entities.CommandsType, Twitchbot.Models.Domain.Models.CommandsTypeUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.CommandsTypeUpdateModel, Twitchbot.Models.Data.Entities.CommandsType>();

        }

    }
}
