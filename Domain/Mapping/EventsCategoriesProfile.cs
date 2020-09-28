using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class EventsCategoriesProfile
        : AutoMapper.Profile
        {
            public EventsCategoriesProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.EventsCategories, Twitchbot.Common.Models.Domain.Models.EventsCategoriesReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.EventsCategoriesCreateModel, Twitchbot.Common.Models.Data.Entities.EventsCategories>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.EventsCategories, Twitchbot.Common.Models.Domain.Models.EventsCategoriesUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.EventsCategoriesUpdateModel, Twitchbot.Common.Models.Data.Entities.EventsCategories>();

            }

        }
}