using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class SettingsProfile
        : AutoMapper.Profile
    {
        public SettingsProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Settings, Twitchbot.Models.Domain.Models.SettingsReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.SettingsCreateModel, Twitchbot.Models.Data.Entities.Settings>();

            CreateMap<Twitchbot.Models.Data.Entities.Settings, Twitchbot.Models.Domain.Models.SettingsUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.SettingsUpdateModel, Twitchbot.Models.Data.Entities.Settings>();

        }

    }
}
