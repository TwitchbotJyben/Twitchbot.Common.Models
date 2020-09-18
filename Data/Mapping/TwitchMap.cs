using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class TwitchMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.Twitch>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.Twitch> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("twitch", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Token)
                .HasColumnName("token")
                .HasColumnType("character varying(50)")
                .HasMaxLength(50);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("integer");

            builder.Property(t => t.ClientId)
                .HasColumnName("client_id")
                .HasColumnType("character varying(50)")
                .HasMaxLength(50);

            builder.Property(t => t.RefreshToken)
                .HasColumnName("refresh_token")
                .HasColumnType("character varying(50)")
                .HasMaxLength(50);

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserTwitches)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_twitch_users");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "twitch";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Token = "token";
            public const string UserId = "user_id";
            public const string ClientId = "client_id";
            public const string RefreshToken = "refresh_token";
        }
        #endregion
    }
}
