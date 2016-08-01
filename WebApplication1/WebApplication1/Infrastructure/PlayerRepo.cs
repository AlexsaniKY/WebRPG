using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Creature;

namespace WebApplication1.Infrastructure
{
    public class PlayerRepo : GenericRepository<Player>
    {
        public PlayerRepo(AppDbContext db) : base(db) { }
    }
}