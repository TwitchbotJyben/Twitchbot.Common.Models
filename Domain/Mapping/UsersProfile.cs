using System;
using AutoMapper;
using Twitchbot.Models.Data.Entities;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Mapping
{
    public partial class UsersProfile
        : AutoMapper.Profile
    {
        public UsersProfile()
        {
            CreateMap<Twitchbot.Models.Data.Entities.Users, Twitchbot.Models.Domain.Models.UsersReadModel>();

            CreateMap<Twitchbot.Models.Domain.Models.UsersCreateModel, Twitchbot.Models.Data.Entities.Users>();

            CreateMap<Twitchbot.Models.Data.Entities.Users, Twitchbot.Models.Domain.Models.UsersUpdateModel>();

            CreateMap<Twitchbot.Models.Domain.Models.UsersUpdateModel, Twitchbot.Models.Data.Entities.Users>();

        }

    }
}
