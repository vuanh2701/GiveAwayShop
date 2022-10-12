using ReuseShop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReuseShop.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ReuseShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ReuseShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        } 
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
