using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Twitchbot.Common.Models.Data
{
    public partial class TwitchbotContext : DbContext
    {
        public TwitchbotContext(DbContextOptions<TwitchbotContext> options) : base(options) { }

        #region Generated Properties
        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Actions> Actions { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Commands> Commands { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.CommandsType> CommandsTypes { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Events> Events { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.EventsCategories> EventsCategories { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Extension> Extensions { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Moderators> Moderators { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.PgStatStatements> PgStatStatements { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Rights> Rights { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Settings> Settings { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Spotify> Spotifies { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Tokens> Tokens { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Twitch> Twitches { get; set; }

        public virtual DbSet<Twitchbot.Common.Models.Data.Entities.Users> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.ActionsMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.CommandsMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.CommandsTypeMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.EventsCategoriesMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.EventsMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.ExtensionMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.ModeratorsMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.PgStatStatementsMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.RightsMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.SettingsMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.SpotifyMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.TokensMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.TwitchMap());
            modelBuilder.ApplyConfiguration(new Twitchbot.Common.Models.Data.Mapping.UsersMap());
            #endregion
        }
    }
}