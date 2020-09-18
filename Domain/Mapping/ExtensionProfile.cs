using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class ExtensionProfile
        : AutoMapper.Profile
    {
        public ExtensionProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Extension, Twitchbot.Models.Domain.Models.ExtensionReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.ExtensionCreateModel, Twitchbot.Models.Data.Entities.Extension>();

            CreateMap<Twitchbot.Models.Data.Entities.Extension, Twitchbot.Models.Domain.Models.ExtensionUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.ExtensionUpdateModel, Twitchbot.Models.Data.Entities.Extension>();

        }

    }
}
