using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IConsignmentCategory : IRepository<ConsignmentCategory>
    {

    }
    public class ConsignmentCategoryRepository : RepositoryBase<ConsignmentCategory>, IConsignmentCategory
    {
        public ConsignmentCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
