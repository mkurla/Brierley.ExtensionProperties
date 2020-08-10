﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(ExtensionPropertyDbContext))]
    [Migration("20200809073158_ExtensionPropsFirst")]
    partial class ExtensionPropsFirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("extensionprops")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Repository.Models.ExtensionDomain", b =>
                {
                    b.Property<int>("ExtensionDomainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("DisplayText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<string>("TargetTableName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ExtensionDomainId");

                    b.HasIndex("ExtensionDomainId", "TargetTableName")
                        .IsUnique();

                    b.ToTable("ExtensionDomains");
                });

            modelBuilder.Entity("Repository.Models.ExtensionProperty", b =>
                {
                    b.Property<int>("ExtensionPropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ColumnName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DataType")
                        .HasColumnType("text");

                    b.Property<string>("DefaultValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("DisplayText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Encryption")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ExtensionDomainId")
                        .HasColumnType("integer");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDsar")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsRtbf")
                        .HasColumnType("boolean");

                    b.Property<string>("StringMinMax")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ExtensionPropertyId");

                    b.HasIndex("ExtensionDomainId", "ColumnName")
                        .IsUnique();

                    b.ToTable("ExtensionProperties");
                });

            modelBuilder.Entity("Repository.Models.ExtensionProperty", b =>
                {
                    b.HasOne("Repository.Models.ExtensionDomain", "ExtensionDomain")
                        .WithMany()
                        .HasForeignKey("ExtensionDomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}