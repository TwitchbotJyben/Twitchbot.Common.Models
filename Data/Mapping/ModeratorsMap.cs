using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Mapping
{
    public partial class ModeratorsMap
        : IEntityTypeConfiguration<Twitchbot.Common.Models.Data.Entities.Moderators>
        {
            public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Common.Models.Data.Entities.Moderators> builder)
            {
                #region Generated Configure
            // table
            builder.ToTable("moderators", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("integer");

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserModerators)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_moderators_users");

            #endregion
            }

            #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "moderators";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Name = "name";
            public const string UserId = "user_id";
        }
        #endregion
        }
}