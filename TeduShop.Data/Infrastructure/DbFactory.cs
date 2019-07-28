namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TeduShopDbContext db;

        public TeduShopDbContext Init()
        {
            if (db == null)
            {
                db = new TeduShopDbContext();
            }
            return db;
        }

        protected override void DisposeCore()
        {
            if (db != null)
            {
                db.Dispose();
            }
        }
    }
}