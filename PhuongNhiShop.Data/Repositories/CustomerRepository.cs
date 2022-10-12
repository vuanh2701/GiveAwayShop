using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface ICustomerRepository
    {

    }
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
