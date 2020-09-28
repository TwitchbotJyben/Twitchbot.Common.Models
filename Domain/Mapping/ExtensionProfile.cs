using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class ExtensionProfile
        : AutoMapper.Profile
        {
            public ExtensionProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Extension, Twitchbot.Common.Models.Domain.Models.ExtensionReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.ExtensionCreateModel, Twitchbot.Common.Models.Data.Entities.Extension>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Extension, Twitchbot.Common.Models.Domain.Models.ExtensionUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.ExtensionUpdateModel, Twitchbot.Common.Models.Data.Entities.Extension>();

            }

        }
}