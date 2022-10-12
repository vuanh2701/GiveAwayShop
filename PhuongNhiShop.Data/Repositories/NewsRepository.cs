using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface INewsRepository
    {

    }
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        public NewsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
