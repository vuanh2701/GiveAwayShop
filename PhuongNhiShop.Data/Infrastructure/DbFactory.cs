using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReuseShop.Data.Infrastructure
{
     public class DbFactory : Disposable, IDbFactory
    {
        ReuseShopDbContext dbContext;
        public ReuseShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ReuseShopDbContext());
        }

        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
