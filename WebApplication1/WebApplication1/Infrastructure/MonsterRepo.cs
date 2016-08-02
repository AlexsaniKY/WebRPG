using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Creature;

namespace WebApplication1.Infrastructure
{
    public class MonsterRepo: GenericRepository<Monster>
    {
        public MonsterRepo(AppDbContext db): base(db) { }
    }
}