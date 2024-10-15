﻿// <auto-generated />
using System;
using Izzet.DataAccess.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Izzet.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240227102030_Model")]
    partial class Model
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Izzet.Model.TodoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CustomerPrice")
                        .HasColumnType("float");

                    b.Property<int>("DeletedId")
                        .HasColumnType("int");

                    b.Property<string>("HomeLandKod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomePrice")
                        .HasColumnType("int");

                    b.Property<int>("Kod")
                        .HasColumnType("int");

                    b.Property<string>("OwnName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OwnPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("WinForm");
                });
#pragma warning restore 612, 618
        }
    }
}
