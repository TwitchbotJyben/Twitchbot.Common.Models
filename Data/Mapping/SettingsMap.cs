using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Mapping
{
    public partial class SettingsMap
        : IEntityTypeConfiguration<Twitchbot.Common.Models.Data.Entities.Settings>
        {
            public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Common.Models.Data.Entities.Settings> builder)
            {
                #region Generated Configure
            // table
            builder.ToTable("settings", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("boolean");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("integer");

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserSettings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_settings_common_users_common");

            #endregion
            }

            #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "settings";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Name = "name";
            public const string Activated = "activated";
            public const string UserId = "user_id";
        }
        #endregion
        }
}