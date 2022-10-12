using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IPageRepository
    {

    }
    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
