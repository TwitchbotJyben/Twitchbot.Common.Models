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
            builder.ToTable("twitch", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Token)
                .HasColumnName("token")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("int");

            builder.Property(t => t.ClientId)
                .HasColumnName("client_id")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.RefreshToken)
                .HasColumnName("refresh_token")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserTwitches)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_twitch_users");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "twitch";

        public const string ColumnId = "id";
        public const string ColumnToken = "token";
        public const string ColumnUserId = "user_id";
        public const string ColumnClientId = "client_id";
        public const string ColumnRefreshToken = "refresh_token";
        #endregion
    }
}
