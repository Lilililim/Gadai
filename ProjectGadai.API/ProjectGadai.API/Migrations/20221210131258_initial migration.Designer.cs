﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectGadai.API.Data;

#nullable disable

namespace ProjectGadai.API.Migrations
{
    [DbContext(typeof(ProjectGadaiDbContext))]
    [Migration("20221210131258_initial migration")]
    partial class initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectGadai.API.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Maks_transaksi")
                        .HasColumnType("int");

                    b.Property<string>("Nama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("No_hp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tanggal_masuk")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
