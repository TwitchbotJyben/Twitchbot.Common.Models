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
            builder.ToTable("commands", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Timer)
                .HasColumnName("timer")
                .HasColumnType("int");

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("bit");

            builder.Property(t => t.Response)
                .HasColumnName("response")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.UseId)
                .IsRequired()
                .HasColumnName("use_id")
                .HasColumnType("int");

            builder.Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.TypeId)
                .IsRequired()
                .HasColumnName("type_id")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.TypeCommandsType)
                .WithMany(t => t.TypeCommands)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_commands_common_commands_type_common");

            builder.HasOne(t => t.UseUsers)
                .WithMany(t => t.UseCommands)
                .HasForeignKey(d => d.UseId)
                .HasConstraintName("FK_commands_common_users_common");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "commands";

        public const string ColumnId = "id";
        public const string ColumnTimer = "timer";
        public const string ColumnActivated = "activated";
        public const string ColumnResponse = "response";
        public const string ColumnUseId = "use_id";
        public const string ColumnName = "name";
        public const string ColumnTypeId = "type_id";
        #endregion
    }
}
