using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface INewsCategoryRepository : IRepository<NewsCategory>
    {

    }
    public class NewsCategoryRepository : RepositoryBase<NewsCategory>, INewsCategoryRepository
    {
        public NewsCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
