using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class UsersProfile
        : AutoMapper.Profile
        {
            public UsersProfile()
            {
                CreateMap<Twitchbot.Common.Models.Data.Entities.Users, Twitchbot.Common.Models.Domain.Models.UsersReadModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.UsersCreateModel, Twitchbot.Common.Models.Data.Entities.Users>();

                CreateMap<Twitchbot.Common.Models.Data.Entities.Users, Twitchbot.Common.Models.Domain.Models.UsersUpdateModel>();

                CreateMap<Twitchbot.Common.Models.Domain.Models.UsersUpdateModel, Twitchbot.Common.Models.Data.Entities.Users>();

            }

        }
}