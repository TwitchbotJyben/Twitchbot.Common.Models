using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class RightsMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.Rights>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.Rights> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("rights", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("text");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "rights";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Description = "description";
        }
        #endregion
    }
}
