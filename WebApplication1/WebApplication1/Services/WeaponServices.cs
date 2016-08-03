using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Items;
using WebApplication1.Infrastructure;
using WebApplication1.Services;
using WebApplication1.Services.DTO;

namespace WebApplication1.Services
{
    public class WeaponServices: GenericServices<Weapon>
    {
        public WeaponServices()
        {
            _repo = new WeaponRepo(AppDbContext.Create());
        }

        //public Weapon GetWeapon(int id)
        //{
        //    var query = _repo.Get(id);
        //    return new Weapon((from w in query
        //            select new WeaponDTO()
        //            {
        //                Id = w.Id,
        //                Active = w.Active,
        //                Damage = w.Damage,
        //                Name = w.Name
        //            }).FirstOrDefault());
        //}

        //public IEnumerable<Weapon> EnumerateAll() { return _repo.Enumerate(); }
    }
}