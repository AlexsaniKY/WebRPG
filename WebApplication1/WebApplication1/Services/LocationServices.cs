using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Locations;
using WebApplication1.Infrastructure;

namespace WebApplication1.Services
{
    public class LocationServices: GenericServices<Location>
    {
        public LocationServices()
        {
            _repo = new LocationRepo(AppDbContext.Create());
        }
    }
}