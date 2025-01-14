using Fragrantica.Models;
using Microsoft.EntityFrameworkCore;

namespace Fragrantica.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Eau de Parfum", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Parfum", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Eau de Toilette", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 1, Name = "Cedrat Boise", Description = "Elegant fragrance with woody notes", PerfumeHouse = "Mancera", SerialNumber = "4589ABD12", Price = 120, CategoryId = 1, ImageUrl = "" },
               new Product { Id = 2, Name = "Hindu Kush", Description = "Elegant fragrance with woody and green notes", PerfumeHouse = "Mancera", SerialNumber = "4589AFC15", Price = 150, CategoryId = 1, ImageUrl = "" },
               new Product { Id = 3, Name = "Sculpture", Description = "Elegant fragrance with fresh citrusy notes", PerfumeHouse = "Nikos", SerialNumber = "8219GBK12", Price = 45, CategoryId = 3, ImageUrl = "" }
               );
        }
    }
}
