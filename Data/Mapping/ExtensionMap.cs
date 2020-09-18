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
            builder.ToTable("extension", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("title")
                .HasColumnType("character varying(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Text)
                .HasColumnName("text")
                .HasColumnType("character varying(250)")
                .HasMaxLength(250);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("integer");

            // relationships
            builder.HasOne(t => t.UserUsers)
                .WithMany(t => t.UserExtensions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_extension_web_users_common");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "extension";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Title = "title";
            public const string Text = "text";
            public const string UserId = "user_id";
        }
        #endregion
    }
}
