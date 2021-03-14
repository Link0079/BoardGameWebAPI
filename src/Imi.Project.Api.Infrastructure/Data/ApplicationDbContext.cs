using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Entities.Users;
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
        
        }

    }
}
