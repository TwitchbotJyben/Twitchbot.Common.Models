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
            builder.ToTable("rights", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("text");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "rights";

        public const string ColumnId = "id";
        public const string ColumnDescription = "description";
        #endregion
    }
}
