﻿// <auto-generated />
using System;
using Infantes.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infantes.Database.Migrations
{
    [DbContext(typeof(InfantContext))]
    [Migration("20200730001927_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infantes.Domain.Infant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Infants");
                });

            modelBuilder.Entity("Infantes.Domain.Infant", b =>
                {
                    b.OwnsOne("Infantes.Domain.ValueObjects.Metric", "InfantMetric", b1 =>
                        {
                            b1.Property<int>("InfantId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<decimal>("Length")
                                .HasColumnName("Length")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("Perimeter")
                                .HasColumnName("Perimeter")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("Weight")
                                .HasColumnName("Weight")
                                .HasColumnType("decimal(18,2)");

                            b1.HasKey("InfantId");

                            b1.ToTable("Infants");

                            b1.WithOwner()
                                .HasForeignKey("InfantId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}