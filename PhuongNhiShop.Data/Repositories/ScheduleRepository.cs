﻿using ReuseShop.Data.Infrastructure;
using ReuseShop.Model.Models;

namespace ReuseShop.Data.Repositories
{
    public interface IScheduleRepository : IRepository<Schedule>
    {

    }
    public class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
