using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class SpotifyMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.Spotify>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.Spotify> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("spotify", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer");

            builder.Property(t => t.Token)
                .HasColumnName("token")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.RefreshToken)
                .HasColumnName("refresh_token")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("integer");

            // relationships
            builder.HasOne(t => t.Users)
                .WithOne(t => t.Spotify)
                .HasForeignKey<Twitchbot.Models.Data.Entities.Spotify>(d => d.Id)
                .HasConstraintName("fk_spotify_user");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "spotify";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Token = "token";
            public const string RefreshToken = "refresh_token";
            public const string UserId = "user_id";
        }
        #endregion
    }
}
