using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class CommandsMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.Commands>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.Commands> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("commands", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Timer)
                .HasColumnName("timer")
                .HasColumnType("integer");

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("boolean");

            builder.Property(t => t.Response)
                .HasColumnName("response")
                .HasColumnType("character varying");

            builder.Property(t => t.UseId)
                .IsRequired()
                .HasColumnName("use_id")
                .HasColumnType("integer");

            builder.Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("character varying(50)")
                .HasMaxLength(50);

            builder.Property(t => t.TypeId)
                .IsRequired()
                .HasColumnName("type_id")
                .HasColumnType("integer");

            // relationships
            builder.HasOne(t => t.TypeCommandsType)
                .WithMany(t => t.TypeCommands)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("fk_commands_common_commands_type_common");

            builder.HasOne(t => t.UseUsers)
                .WithMany(t => t.UseCommands)
                .HasForeignKey(d => d.UseId)
                .HasConstraintName("fk_commands_common_users_common");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "commands";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Timer = "timer";
            public const string Activated = "activated";
            public const string Response = "response";
            public const string UseId = "use_id";
            public const string Name = "name";
            public const string TypeId = "type_id";
        }
        #endregion
    }
}
