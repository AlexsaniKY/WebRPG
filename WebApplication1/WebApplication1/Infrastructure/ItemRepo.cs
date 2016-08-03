using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Items;

namespace WebApplication1.Infrastructure
{
    public class ItemRepo : GenericRepository<Weapon>
    {
        public ItemRepo(AppDbContext db) : base(db) { }
    }
}