using EBunnyShop.Model.Models;
using System.Data.Entity;

namespace EBunnyShop.Data
{
    public class EBunnyShopDbContext : DbContext
    {
        public EBunnyShopDbContext() : base("EBunnyShopConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}