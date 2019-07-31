using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private TeduShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public TeduShopDbContext DbContext
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = _dbFactory.Init();
                    return dbContext;
                }
                else
                {
                    return dbContext;
                }
            }
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
