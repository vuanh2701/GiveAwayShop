using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface ISlideRepository
    {

    }
    public class SlideRepository : RepositoryBase<Slide>
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
