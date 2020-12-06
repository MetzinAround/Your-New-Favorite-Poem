using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Your_New_Favorite_Poem.Constants;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem
{
    public class AuthorsDbContext : DbContext
    {
        public AuthorsDbContext(DbContextOptions<AuthorsDbContext> options) : base(options)
        {

        }

        public DbSet<Author>? Authors { get; set; }
        public DbSet<Poem>? Poems { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Poem>().HasOne(p => p.Author).WithMany(b => b.Poems);
            modelBuilder.Entity<Author>().Property(b => b.CreatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
            modelBuilder.Entity<Author>().Property(b => b.UpdatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
            modelBuilder.Entity<Poem>().Property(b => b.CreatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
            modelBuilder.Entity<Poem>().Property(b => b.UpdatedAt).HasDefaultValue(DateTimeOffset.UtcNow);

        }
        
    }

}

