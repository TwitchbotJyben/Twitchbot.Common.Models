using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class EventsProfile
        : AutoMapper.Profile
        {
            public EventsProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Events, Twitchbot.Common.Models.Domain.Models.EventsReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.EventsCreateModel, Twitchbot.Common.Models.Data.Entities.Events>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Events, Twitchbot.Common.Models.Domain.Models.EventsUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.EventsUpdateModel, Twitchbot.Common.Models.Data.Entities.Events>();

            }

        }
}