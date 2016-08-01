using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Items;

namespace WebApplication1.Infrastructure
{
    public class WeaponRepo : GenericRepository<Weapon>
    {
        public WeaponRepo(AppDbContext db) : base(db) { }
    }
}