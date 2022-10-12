using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface ISupportOnlineRepository
    {

    }
    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
