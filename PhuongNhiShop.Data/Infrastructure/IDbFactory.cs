namespace ReuseShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ReuseShopDbContext Init();
    }
}
