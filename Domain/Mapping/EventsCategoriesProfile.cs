using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class EventsCategoriesProfile
        : AutoMapper.Profile
    {
        public EventsCategoriesProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.EventsCategories, Twitchbot.Models.Domain.Models.EventsCategoriesReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.EventsCategoriesCreateModel, Twitchbot.Models.Data.Entities.EventsCategories>();

            CreateMap<Twitchbot.Models.Data.Entities.EventsCategories, Twitchbot.Models.Domain.Models.EventsCategoriesUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.EventsCategoriesUpdateModel, Twitchbot.Models.Data.Entities.EventsCategories>();

        }

    }
}
