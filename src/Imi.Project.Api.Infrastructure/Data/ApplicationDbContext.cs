﻿using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Infrastructure.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BoardGame> BoardGames { get; set; }
        public DbSet<BoardGameArtist> BoardGameArtists { get; set; }
        public DbSet<BoardGameCategory> BoardGameCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Categories Table
            modelBuilder.Entity<Category>().ToTable("Categories").HasKey(e => e.Id);
            modelBuilder.Entity<Category>().Property(e => e.Name)
                .HasMaxLength(100).IsRequired();
            #endregion

            #region Countries Table
            modelBuilder.Entity<Country>().ToTable("Countries").HasKey(e => e.Id);
            modelBuilder.Entity<Country>().Property(e => e.Name)
                .HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Country>().Property(e => e.CountryCode)
                .HasMaxLength(3);
            #endregion

            #region Publishers Table
            modelBuilder.Entity<Publisher>().ToTable("Publishers").HasKey(e => e.Id);
            modelBuilder.Entity<Publisher>().Property(e => e.Name)
                .HasMaxLength(100).IsRequired();
            #endregion

            #region Artists Table
            modelBuilder.Entity<Artist>().ToTable("Artists").HasKey(e => e.Id);
            modelBuilder.Entity<Artist>().Property(e => e.Name)
                .HasMaxLength(100).IsRequired();
            #endregion

            #region Boadgames Table
            modelBuilder.Entity<BoardGame>().ToTable("BoardGames").HasKey(e => e.Id);
            modelBuilder.Entity<BoardGame>().Property(e => e.Title)
                .HasMaxLength(255).IsRequired();
            modelBuilder.Entity<BoardGame>().Property(e => e.Price)
                .HasColumnType("money");
            //
            //
            #endregion

            #region BoardGameArtist Tabel
            modelBuilder.Entity<BoardGameArtist>().ToTable("BoardGameArtists")
                .HasKey(ba => new { ba.BoardGameId, ba.ArtistId });
            modelBuilder.Entity<BoardGameArtist>().HasOne(ba => ba.BoardGame)
                .WithMany(a => a.Artists).HasForeignKey(ba => ba.BoardGameId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BoardGameArtist>().HasOne(ba => ba.Artist)
                .WithMany(b => b.Artwork).HasForeignKey(ba => ba.ArtistId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region BoardGameCategory Table
            modelBuilder.Entity<BoardGameCategory>().ToTable("BoardGameCategories")
                .HasKey(bc => new { bc.BoardGameId, bc.CategoryId });
            modelBuilder.Entity<BoardGameCategory>().HasOne(bc => bc.BoardGame)
                .WithMany(c => c.Categories).HasForeignKey(bc => bc.BoardGameId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BoardGameCategory>().HasOne(bc => bc.Category)
                .WithMany(b => b.BoardGames).HasForeignKey(bc => bc.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            CategorySeeder.Seed(modelBuilder);
            CountrySeeder.Seed(modelBuilder);
            PublisherSeeder.Seed(modelBuilder);
            ArtistSeeder.Seed(modelBuilder);
            BoardGameSeeder.Seed(modelBuilder);
            BoardGameArtistSeeder.Seed(modelBuilder);
            BoardGameCategorySeeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

    }
}
