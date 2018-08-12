using EBunnuShop.Model.Models;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}