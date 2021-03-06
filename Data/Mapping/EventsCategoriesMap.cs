using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Mapping
{
    public partial class EventsCategoriesMap
        : IEntityTypeConfiguration<Twitchbot.Common.Models.Data.Entities.EventsCategories>
        {
            public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Common.Models.Data.Entities.EventsCategories> builder)
            {
                #region Generated Configure
            // table
            builder.ToTable("events_categories", "public");

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
            public const string Name = "events_categories";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Name = "name";
        }
        #endregion
        }
}