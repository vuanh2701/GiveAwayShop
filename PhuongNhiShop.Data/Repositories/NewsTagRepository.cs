using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface INewsTagRepository
    {

    }
    public class NewsTagRepository : RepositoryBase<NewsTag>, INewsTagRepository
    {
        public NewsTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
