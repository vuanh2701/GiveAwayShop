using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IMenuRepository
    {

    }
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
