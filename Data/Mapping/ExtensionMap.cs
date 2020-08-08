using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class ExtensionMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.Extension>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.Extension> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("extension", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("title")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Text)
                .HasColumnName("text")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserExtensions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_extension_web_users_common");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "extension";

        public const string ColumnId = "id";
        public const string ColumnTitle = "title";
        public const string ColumnText = "text";
        public const string ColumnUserId = "user_id";
        #endregion
    }
}
