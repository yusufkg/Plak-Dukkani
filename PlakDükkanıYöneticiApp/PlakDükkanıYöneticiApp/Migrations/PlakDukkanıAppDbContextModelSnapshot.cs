﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlakDükkanıYöneticiApp.Context;

#nullable disable

namespace PlakDükkanıYöneticiApp.Migrations
{
    [DbContext(typeof(PlakDukkanıAppDbContext))]
    partial class PlakDukkanıAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlakDükkanıYöneticiApp.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AlbumCikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<double>("AlbumFiyat")
                        .HasColumnType("float");

                    b.Property<int>("IndirimOranı")
                        .HasColumnType("int");

                    b.Property<int>("SanatciId")
                        .HasColumnType("int");

                    b.Property<bool>("SatısDurum")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("SanatciId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("PlakDükkanıYöneticiApp.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("PlakDükkanıYöneticiApp.Entities.Sanatci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AlbumSanatcısı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sanatcis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumSanatcısı = "Hadise"
                        },
                        new
                        {
                            Id = 2,
                            AlbumSanatcısı = "Tarkan"
                        },
                        new
                        {
                            Id = 3,
                            AlbumSanatcısı = "Azer Bülbül"
                        },
                        new
                        {
                            Id = 4,
                            AlbumSanatcısı = "Rihanna"
                        },
                        new
                        {
                            Id = 5,
                            AlbumSanatcısı = "Lady Gaga"
                        });
                });

            modelBuilder.Entity("PlakDükkanıYöneticiApp.Entities.Album", b =>
                {
                    b.HasOne("PlakDükkanıYöneticiApp.Entities.Sanatci", "Sanatci")
                        .WithMany("Albums")
                        .HasForeignKey("SanatciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sanatci");
                });

            modelBuilder.Entity("PlakDükkanıYöneticiApp.Entities.Sanatci", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
