using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Common.Models.Data.Mapping
{
    public partial class TokensMap
        : IEntityTypeConfiguration<Twitchbot.Common.Models.Data.Entities.Tokens>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Common.Models.Data.Entities.Tokens> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tokens", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("integer");

            builder.Property(t => t.Token)
                .IsRequired()
                .HasColumnName("token")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Created)
                .IsRequired()
                .HasColumnName("created")
                .HasColumnType("date");

            builder.Property(t => t.CreatedByIp)
                .IsRequired()
                .HasColumnName("created_by_ip")
                .HasColumnType("character varying(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Expires)
                .IsRequired()
                .HasColumnName("expires")
                .HasColumnType("date");

            builder.Property(t => t.ReplacedByToken)
                .HasColumnName("replaced_by_token")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "tokens";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Token = "token";
            public const string Created = "created";
            public const string CreatedByIp = "created_by_ip";
            public const string Expires = "expires";
            public const string ReplacedByToken = "replaced_by_token";
        }
        #endregion
    }
}
