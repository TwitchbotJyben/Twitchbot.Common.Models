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
            builder.ToTable("spotify", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int");

            builder.Property(t => t.Token)
                .HasColumnName("token")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.RefreshToken)
                .HasColumnName("refresh_token")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Users)
                .WithOne(t => t.Spotify)
                .HasForeignKey<Twitchbot.Models.Data.Entities.Spotify>(d => d.Id)
                .HasConstraintName("FK_spotify_user");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "spotify";

        public const string ColumnId = "id";
        public const string ColumnToken = "token";
        public const string ColumnRefreshToken = "refresh_token";
        public const string ColumnUserId = "user_id";
        #endregion
    }
}
