using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface INewsCategoryRepository
    {

    }
    public class NewsCategoryRepository : RepositoryBase<NewsCategory>, INewsCategoryRepository
    {
        public NewsCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
