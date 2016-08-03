using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Creature;
using WebApplication1.Infrastructure;

namespace WebApplication1.Services
{
    public class MonsterServices:GenericServices<Monster>
    {
        public MonsterServices()
        {
            _repo = new MonsterRepo(AppDbContext.Create());
        }
    }
}