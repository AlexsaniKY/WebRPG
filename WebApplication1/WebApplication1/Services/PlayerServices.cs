using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Creature;
using WebApplication1.Infrastructure;
using WebApplication1.Services.DTO;

namespace WebApplication1.Services
{
    public class PlayerServices
    {
        internal PlayerRepo _repo;
        internal WeaponServices weaponservices;

        public PlayerServices()
        {
            _repo = new PlayerRepo(AppDbContext.Create());
            weaponservices = new WeaponServices();
        }

        public Player GetPlayer(int id)
        {
            var query = _repo.Get(id);
            return new Player((from p in query
                    select new PlayerDTO()
                    {Id = p.Id,
                    Active = p.Active,
                    Name = p.Name,
                    FactionId = p.FactionId,
                    HP = p.HP,
                        WieldedWeaponId = p.WieldedWeaponId,
                        WieldedWeapon = new WeaponDTO()
                    {
                        Id = p.WieldedWeapon.Id,
                        Active = p.WieldedWeapon.Active,
                        Name = p.WieldedWeapon.Name,
                        Damage = p.WieldedWeapon.Damage
                    }
                    }).FirstOrDefault());
        }
    }
}