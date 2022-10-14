using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;
using System.Linq;

namespace ReuseShop.Data.Repositories
{
    public interface INewsRepository : IRepository<News>
    {
        IEnumerable<News> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        public NewsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<News> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from n in DbContext.News
                        join nt in DbContext.NewsTags
                        on n.Id equals nt.NewsID
                        where nt.TagID == tag
                        orderby n.CreateDate descending
                        select n;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}
