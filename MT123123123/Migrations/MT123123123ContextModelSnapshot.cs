﻿// <auto-generated />
using System;
using MT123123123.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MT123123123.Migrations
{
    [DbContext(typeof(MT123123123Context))]
    partial class MT123123123ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MT123123123.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Msg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Message");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Msg = "Hi all y'alls",
                            Name = "Billy Bob",
                            PostedAt = new DateTime(2019, 11, 6, 17, 33, 51, 319, DateTimeKind.Local).AddTicks(9936)
                        },
                        new
                        {
                            Id = 2,
                            Msg = "Hi",
                            Name = "Sally Joe",
                            PostedAt = new DateTime(2019, 11, 6, 17, 33, 51, 322, DateTimeKind.Local).AddTicks(9736)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
