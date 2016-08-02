using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain;

namespace WebApplication1.Infrastructure
{
    public class FactionRepo: GenericRepository<Faction>
    {
        public FactionRepo(AppDbContext db) : base(db) { }
    }
}