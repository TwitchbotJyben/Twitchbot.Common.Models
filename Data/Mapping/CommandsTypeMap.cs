using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class CommandsTypeMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.CommandsType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.CommandsType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("commands_type", "public");

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

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "commands_type";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Name = "name";
        }
        #endregion
    }
}
