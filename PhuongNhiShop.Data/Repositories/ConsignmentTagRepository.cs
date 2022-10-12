using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IConsignmentTag
    {

    }
    public class ConsignmentTagRepository : RepositoryBase<ConsignmentTag>, IConsignmentTag
    {
        public ConsignmentTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
