using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IStaffRepository : IRepository<Staff>
    {

    }
    public class StaffRepository : RepositoryBase<Staff>, IStaffRepository
    {
        public StaffRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
