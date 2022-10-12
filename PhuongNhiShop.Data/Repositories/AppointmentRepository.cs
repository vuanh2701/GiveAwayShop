using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IAppointmentRepository
    {

    }
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
