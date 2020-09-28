using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class SettingsProfile
        : AutoMapper.Profile
        {
            public SettingsProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Settings, Twitchbot.Common.Models.Domain.Models.SettingsReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.SettingsCreateModel, Twitchbot.Common.Models.Data.Entities.Settings>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Settings, Twitchbot.Common.Models.Domain.Models.SettingsUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.SettingsUpdateModel, Twitchbot.Common.Models.Data.Entities.Settings>();

            }

        }
}