using Microsoft.EntityFrameworkCore;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem
{
    public class AuthorsDbContext : DbContext
    {
        public AuthorsDbContext(DbContextOptions<AuthorsDbContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; init; }
        public DbSet<Poem> Poems { get; init; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Poem>().HasOne(p => p.Author).WithMany(b => b.Poems);
            modelBuilder.Entity<Author>().Property(b => b.CreatedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Author>().Property(b => b.UpdatedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Poem>().Property(b => b.CreatedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Poem>().Property(b => b.UpdatedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}