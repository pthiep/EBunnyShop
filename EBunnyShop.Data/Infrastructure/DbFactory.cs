using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBunnyShop.Data.Infrastructure
{
    class DbFactory : Disposable, IDbFactory
    {
        EBunnyShopDbContext dbContext;
        public EBunnyShopDbContext Init()
        {
            return dbContext ?? (dbContext = new EBunnyShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
