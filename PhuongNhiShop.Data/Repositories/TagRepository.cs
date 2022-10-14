using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReuseShop.Data.Repositories
{
    public interface ITagRepository : IRepository<TagRepository>
    {

    }
    public class TagRepository : RepositoryBase<TagRepository>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
