using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class SettingsMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.Settings>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.Settings> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("settings", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("bit");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserSettings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_settings_common_users_common");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "settings";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnActivated = "activated";
        public const string ColumnUserId = "user_id";
        #endregion
    }
}
