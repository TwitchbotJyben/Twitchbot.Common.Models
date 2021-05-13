using System;
using AutoMapper;
using Twitchbot.Common.Models.Data.Entities;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Mapping
{
    public partial class PgStatStatementsProfile
        : AutoMapper.Profile
    {
        public PgStatStatementsProfile()
        {
            CreateMap<Twitchbot.Common.Models.Data.Entities.PgStatStatements, Twitchbot.Common.Models.Domain.Models.PgStatStatementsReadModel>();

            CreateMap<Twitchbot.Common.Models.Domain.Models.PgStatStatementsCreateModel, Twitchbot.Common.Models.Data.Entities.PgStatStatements>();

            CreateMap<Twitchbot.Common.Models.Data.Entities.PgStatStatements, Twitchbot.Common.Models.Domain.Models.PgStatStatementsUpdateModel>();

            CreateMap<Twitchbot.Common.Models.Domain.Models.PgStatStatementsUpdateModel, Twitchbot.Common.Models.Data.Entities.PgStatStatements>();

            CreateMap<Twitchbot.Common.Models.Domain.Models.PgStatStatementsReadModel, Twitchbot.Common.Models.Domain.Models.PgStatStatementsUpdateModel>();

        }

    }
}
