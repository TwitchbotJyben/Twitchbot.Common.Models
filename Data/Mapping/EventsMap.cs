using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class EventsMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.Events>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.Events> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("events", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserName)
                .IsRequired()
                .HasColumnName("user_name")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Time)
                .IsRequired()
                .HasColumnName("time")
                .HasColumnType("datetime");

            builder.Property(t => t.Object)
                .IsRequired()
                .HasColumnName("object")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ActionId)
                .IsRequired()
                .HasColumnName("action_id")
                .HasColumnType("int");

            builder.Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("category_id")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.ActionActions)
                .WithMany(t => t.ActionEvents)
                .HasForeignKey(d => d.ActionId)
                .HasConstraintName("FK_events_web_actions_web");

            builder.HasOne(t => t.CategoryEventsCategories)
                .WithMany(t => t.CategoryEvents)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_events_web_categories_web");

            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserEvents)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_events_web_users_common");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "events";

        public const string ColumnId = "id";
        public const string ColumnUserName = "user_name";
        public const string ColumnTime = "time";
        public const string ColumnObject = "object";
        public const string ColumnActionId = "action_id";
        public const string ColumnCategoryId = "category_id";
        public const string ColumnUserId = "user_id";
        #endregion
    }
}
