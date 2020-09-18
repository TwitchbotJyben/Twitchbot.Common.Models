using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Twitchbot.Models.Data.Mapping
{
    public partial class PgStatStatementsMap
        : IEntityTypeConfiguration<Twitchbot.Models.Data.Entities.PgStatStatements>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Twitchbot.Models.Data.Entities.PgStatStatements> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("pg_stat_statements", "public");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Userid)
                .HasColumnName("userid")
                .HasColumnType("oid");

            builder.Property(t => t.Dbid)
                .HasColumnName("dbid")
                .HasColumnType("oid");

            builder.Property(t => t.Queryid)
                .HasColumnName("queryid")
                .HasColumnType("bigint");

            builder.Property(t => t.Query)
                .HasColumnName("query")
                .HasColumnType("text");

            builder.Property(t => t.Calls)
                .HasColumnName("calls")
                .HasColumnType("bigint");

            builder.Property(t => t.TotalTime)
                .HasColumnName("total_time")
                .HasColumnType("double precision");

            builder.Property(t => t.MinTime)
                .HasColumnName("min_time")
                .HasColumnType("double precision");

            builder.Property(t => t.MaxTime)
                .HasColumnName("max_time")
                .HasColumnType("double precision");

            builder.Property(t => t.MeanTime)
                .HasColumnName("mean_time")
                .HasColumnType("double precision");

            builder.Property(t => t.StddevTime)
                .HasColumnName("stddev_time")
                .HasColumnType("double precision");

            builder.Property(t => t.Rows)
                .HasColumnName("rows")
                .HasColumnType("bigint");

            builder.Property(t => t.SharedBlksHit)
                .HasColumnName("shared_blks_hit")
                .HasColumnType("bigint");

            builder.Property(t => t.SharedBlksRead)
                .HasColumnName("shared_blks_read")
                .HasColumnType("bigint");

            builder.Property(t => t.SharedBlksDirtied)
                .HasColumnName("shared_blks_dirtied")
                .HasColumnType("bigint");

            builder.Property(t => t.SharedBlksWritten)
                .HasColumnName("shared_blks_written")
                .HasColumnType("bigint");

            builder.Property(t => t.LocalBlksHit)
                .HasColumnName("local_blks_hit")
                .HasColumnType("bigint");

            builder.Property(t => t.LocalBlksRead)
                .HasColumnName("local_blks_read")
                .HasColumnType("bigint");

            builder.Property(t => t.LocalBlksDirtied)
                .HasColumnName("local_blks_dirtied")
                .HasColumnType("bigint");

            builder.Property(t => t.LocalBlksWritten)
                .HasColumnName("local_blks_written")
                .HasColumnType("bigint");

            builder.Property(t => t.TempBlksRead)
                .HasColumnName("temp_blks_read")
                .HasColumnType("bigint");

            builder.Property(t => t.TempBlksWritten)
                .HasColumnName("temp_blks_written")
                .HasColumnType("bigint");

            builder.Property(t => t.BlkReadTime)
                .HasColumnName("blk_read_time")
                .HasColumnType("double precision");

            builder.Property(t => t.BlkWriteTime)
                .HasColumnName("blk_write_time")
                .HasColumnType("double precision");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "pg_stat_statements";
        }

        public struct Columns
        {
            public const string Userid = "userid";
            public const string Dbid = "dbid";
            public const string Queryid = "queryid";
            public const string Query = "query";
            public const string Calls = "calls";
            public const string TotalTime = "total_time";
            public const string MinTime = "min_time";
            public const string MaxTime = "max_time";
            public const string MeanTime = "mean_time";
            public const string StddevTime = "stddev_time";
            public const string Rows = "rows";
            public const string SharedBlksHit = "shared_blks_hit";
            public const string SharedBlksRead = "shared_blks_read";
            public const string SharedBlksDirtied = "shared_blks_dirtied";
            public const string SharedBlksWritten = "shared_blks_written";
            public const string LocalBlksHit = "local_blks_hit";
            public const string LocalBlksRead = "local_blks_read";
            public const string LocalBlksDirtied = "local_blks_dirtied";
            public const string LocalBlksWritten = "local_blks_written";
            public const string TempBlksRead = "temp_blks_read";
            public const string TempBlksWritten = "temp_blks_written";
            public const string BlkReadTime = "blk_read_time";
            public const string BlkWriteTime = "blk_write_time";
        }
        #endregion
    }
}
