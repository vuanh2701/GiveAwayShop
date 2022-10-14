using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface INewsTagRepository : IRepository<NewsTag>
    {

    }
    public class NewsTagRepository : RepositoryBase<NewsTag>, INewsTagRepository
    {
        public NewsTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
