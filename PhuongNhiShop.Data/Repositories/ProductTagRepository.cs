using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IProductTagRepository
    {

    }
    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
