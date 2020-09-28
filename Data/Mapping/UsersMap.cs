using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Mapping
{
    public partial class UsersMap
        : IEntityTypeConfiguration<Twitchbot.Common.Models.Data.Entities.Users>
        {
            public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Common.Models.Data.Entities.Users> builder)
            {
                #region Generated Configure
            // table
            builder.ToTable("users", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RightId)
                .HasColumnName("right_id")
                .HasColumnType("integer");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            // relationships
            builder.HasOne(t => t.RightRights)
                .WithMany(t => t.RightUsers)
                .HasForeignKey(d => d.RightId)
                .HasConstraintName("fk_users_rights");

            #endregion
            }

            #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "users";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string RightId = "right_id";
            public const string Name = "name";
        }
        #endregion
        }
}