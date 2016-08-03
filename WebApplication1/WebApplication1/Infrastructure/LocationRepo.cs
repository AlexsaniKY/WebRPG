using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Locations;

namespace WebApplication1.Infrastructure
{
    public class LocationRepo : GenericRepository<Location>
    {
        public LocationRepo(AppDbContext db) : base(db) { }
    }
}