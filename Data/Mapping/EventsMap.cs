using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Mapping
{
    public partial class EventsMap
        : IEntityTypeConfiguration<Twitchbot.Common.Models.Data.Entities.Events>
        {
            public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Common.Models.Data.Entities.Events> builder)
            {
                #region Generated Configure
            // table
            builder.ToTable("events", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserName)
                .IsRequired()
                .HasColumnName("user_name")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Time)
                .IsRequired()
                .HasColumnName("time")
                .HasColumnType("timestamp without time zone");

            builder.Property(t => t.Object)
                .IsRequired()
                .HasColumnName("object")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ActionId)
                .IsRequired()
                .HasColumnName("action_id")
                .HasColumnType("integer");

            builder.Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("category_id")
                .HasColumnType("integer");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("integer");

            // relationships
            builder.HasOne(t => t.ActionActions)
                .WithMany(t => t.ActionEvents)
                .HasForeignKey(d => d.ActionId)
                .HasConstraintName("fk_events_web_actions_web");

            builder.HasOne(t => t.CategoryEventsCategories)
                .WithMany(t => t.CategoryEvents)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk_events_web_categories_web");

            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserEvents)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_events_web_users_common");

            #endregion
            }

            #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "events";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string UserName = "user_name";
            public const string Time = "time";
            public const string Object = "object";
            public const string ActionId = "action_id";
            public const string CategoryId = "category_id";
            public const string UserId = "user_id";
        }
        #endregion
        }
}