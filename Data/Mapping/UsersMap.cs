using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class UsersMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.Users>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.Users> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("users", "dbo");

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

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "users";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        #endregion
    }
}
