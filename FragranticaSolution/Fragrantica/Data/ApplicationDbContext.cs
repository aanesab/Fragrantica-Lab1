using Fragrantica.Models;
using Microsoft.EntityFrameworkCore;

namespace Fragrantica.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Eau de Parfum", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Parfum", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Eau de Toilette", DisplayOrder = 3 }
                );          
        }
    }
}
