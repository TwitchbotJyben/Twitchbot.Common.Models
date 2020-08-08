using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class ActionsProfile
        : AutoMapper.Profile
    {
        public ActionsProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Actions, Twitchbot.Models.Domain.Models.ActionsReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.ActionsCreateModel, Twitchbot.Models.Data.Entities.Actions>();

            CreateMap<Twitchbot.Models.Data.Entities.Actions, Twitchbot.Models.Domain.Models.ActionsUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.ActionsUpdateModel, Twitchbot.Models.Data.Entities.Actions>();

        }

    }
}
