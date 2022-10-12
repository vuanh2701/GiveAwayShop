using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IMenuGroupRepository
    {

    }
    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
