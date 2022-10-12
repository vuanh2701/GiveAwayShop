using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IFooterRepository{}
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
