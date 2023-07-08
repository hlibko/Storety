using Microsoft.EntityFrameworkCore;
using Storety.Models;

namespace Storety.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                Enumerable.Range(1, 10).Select(x => new Category { Id = x, Name = $"Category {x}" })
            );
        }
    }
}
