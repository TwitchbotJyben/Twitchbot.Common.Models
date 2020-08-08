using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class ModeratorsMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.Moderators>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.Moderators> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("moderators", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserModerators)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_moderators_users");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "moderators";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnUserId = "user_id";
        #endregion
    }
}
