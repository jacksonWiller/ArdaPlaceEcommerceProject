﻿// <auto-generated />
using System;
using Customers.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.PublicApi.Migrations.EventStoreDb
{
    [DbContext(typeof(EventStoreDbContext))]
    [Migration("20230226145437_EventStore")]
    partial class EventStore
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Latin1_General_CI_AI")
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop.Core.Events.EventStore", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AggregateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Data")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasComment("JSON serialized event");

                    b.Property<string>("MessageType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("OccurredOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.HasKey("Id");

                    b.ToTable("EventStores");
                });
#pragma warning restore 612, 618
        }
    }
}
