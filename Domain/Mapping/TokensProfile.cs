using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class TokensProfile
        : AutoMapper.Profile
    {
        public TokensProfile()
        {
            CreateMap<Twitchbot.Common.Models.Data.Entities.Tokens, Twitchbot.Common.Models.Domain.Models.TokensReadModel>();

            CreateMap<Twitchbot.Common.Models.Domain.Models.TokensCreateModel, Twitchbot.Common.Models.Data.Entities.Tokens>();

            CreateMap<Twitchbot.Common.Models.Data.Entities.Tokens, Twitchbot.Common.Models.Domain.Models.TokensUpdateModel>();

            CreateMap<Twitchbot.Common.Models.Domain.Models.TokensUpdateModel, Twitchbot.Common.Models.Data.Entities.Tokens>();

            CreateMap<Twitchbot.Common.Models.Domain.Models.TokensReadModel, Twitchbot.Common.Models.Domain.Models.TokensUpdateModel>();

        }

    }
}
