﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sdt.Data.Context;

namespace Sdt.Data.Migrations
{
    [DbContext(typeof(SdtDataContext))]
    [Migration("20210113121325_Init_v1")]
    partial class Init_v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Sdt.Domain.Entities.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Beschreibung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Geburtsdatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutorId");

                    b.ToTable("Autoren");
                });

            modelBuilder.Entity("Sdt.Domain.Entities.Spruch", b =>
                {
                    b.Property<int>("SpruchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("SpruchText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpruchId");

                    b.HasIndex("AutorId");

                    b.ToTable("Sprueche");
                });

            modelBuilder.Entity("Sdt.Domain.Entities.Spruch", b =>
                {
                    b.HasOne("Sdt.Domain.Entities.Autor", "Autor")
                        .WithMany("Sprueche")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("Sdt.Domain.Entities.Autor", b =>
                {
                    b.Navigation("Sprueche");
                });
#pragma warning restore 612, 618
        }
    }
}
