using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IConsignmentRepository : IRepository<Consignment>
    {

    }
    public class ConsignmentRepository : RepositoryBase<Consignment>, IConsignmentRepository
    {
        public ConsignmentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
