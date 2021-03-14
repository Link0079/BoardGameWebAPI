﻿// <auto-generated />
using System;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210314171031_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Games.BoardGame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxPlayers")
                        .HasColumnType("int");

                    b.Property<int?>("MinPlayers")
                        .HasColumnType("int");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayTime")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<bool>("Stock")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("PublisherId");

                    b.ToTable("BoardGames");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Games.BoardGameArtist", b =>
                {
                    b.Property<Guid>("BoardGameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArtistId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BoardGameId", "ArtistId");

                    b.HasIndex("ArtistId");

                    b.ToTable("BoardGameArtists");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Games.BoardGameCategory", b =>
                {
                    b.Property<Guid>("BoardGameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BoardGameId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BoardGameCategories");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Users.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Games.BoardGame", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.Country", "Country")
                        .WithMany("BoardGames")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Publisher", "Publisher")
                        .WithMany("PublishedBoardGames")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Games.BoardGameArtist", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.Users.Artist", "Artist")
                        .WithMany("Artwork")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Games.BoardGame", "BoardGame")
                        .WithMany("Artists")
                        .HasForeignKey("BoardGameId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Games.BoardGameCategory", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.Games.BoardGame", "BoardGame")
                        .WithMany("Categories")
                        .HasForeignKey("BoardGameId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Category", "Category")
                        .WithMany("BoardGames")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Publisher", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Users.Artist", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}