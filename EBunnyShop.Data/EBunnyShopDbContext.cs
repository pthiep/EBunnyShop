using EBunnyShop.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace EBunnyShop.Data
{
    public class EBunnyShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public EBunnyShopDbContext() : base("EBunnyShopConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostTag> PostTags { set; get; }

        public static EBunnyShopDbContext Create()
        {
            return new EBunnyShopDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId }).ToTable("ApplicationUserRoles");
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId).ToTable("ApplicationUserLogins");
            builder.Entity<IdentityRole>().ToTable("ApplicationRoles");
            builder.Entity<IdentityUserClaim>().HasKey(i => i.UserId).ToTable("ApplicationUserClaims");
        }
    }
}