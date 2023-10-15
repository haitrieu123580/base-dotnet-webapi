using Microsoft.EntityFrameworkCore;
using s002API.Models;
namespace s002API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SupplierCategory> SupplierCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SupplierCategory>().HasKey(sc => new { sc.SupplierId, sc.CategoryId });

            modelBuilder.Entity<SupplierCategory>()
                    .HasOne(s => s.Supplier)
                    .WithMany(sc => sc.SupplierCategories)
                    .HasForeignKey(s => s.SupplierId);
            modelBuilder.Entity<SupplierCategory>()
                    .HasOne(c => c.Category)
                    .WithMany(sc => sc.SupplierCategories)
                    .HasForeignKey(c => c.CategoryId);

        }

    }
}
