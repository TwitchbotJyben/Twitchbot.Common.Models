using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class EventsProfile
        : AutoMapper.Profile
    {
        public EventsProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Events, Twitchbot.Models.Domain.Models.EventsReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.EventsCreateModel, Twitchbot.Models.Data.Entities.Events>();

            CreateMap<Twitchbot.Models.Data.Entities.Events, Twitchbot.Models.Domain.Models.EventsUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.EventsUpdateModel, Twitchbot.Models.Data.Entities.Events>();

        }

    }
}
