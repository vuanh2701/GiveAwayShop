using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IBarcodeRepository
    {

    }
    public class BarcodeRepository : RepositoryBase<Barcode>, IBarcodeRepository
    {
        public BarcodeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
