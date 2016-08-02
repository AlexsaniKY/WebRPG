using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Creature;
using WebApplication1.Infrastructure;
using WebApplication1.Services.DTO;

namespace WebApplication1.Services
{
    public class PlayerServices: GenericServices<Player>
    {
        //internal WeaponServices weaponservices;

        public PlayerServices()
        {
            _repo = new PlayerRepo(AppDbContext.Create());
            //weaponservices = new WeaponServices();
        }
        
        //public  Player GetPlayerEntity(int id) { 
        //    return Get(id);
        //}

        //public Player GetPlayer(int id)
        //{
        //    var query = _repo.Get(id);
        //    return new Player((from p in query
        //            select new PlayerDTO()
        //            {Id = p.Id,
        //            Active = p.Active,
        //            Name = p.Name,
        //            FactionId = p.FactionId,
        //            HP = p.HP,
        //                WieldedWeaponId = p.WieldedWeaponId,
        //                WieldedWeapon = new WeaponDTO()
        //            {
        //                Id = p.WieldedWeapon.Id,
        //                Active = p.WieldedWeapon.Active,
        //                Name = p.WieldedWeapon.Name,
        //                Damage = p.WieldedWeapon.Damage
        //            }
        //            }).FirstOrDefault());
        //}

        //public void UpdatePlayer(Player updatedplayer) {
        //    _repo.Update(updatedplayer);
        //    _repo.SaveChanges();
        //}

        //public void AddPlayer(Player newplayer)
        //{
        //    _repo.Add(newplayer);
        //    _repo.SaveChanges();
        //}

        //public void DeletePlayer(int id)
        //{
        //    _repo.Delete(id);
        //    _repo.SaveChanges();
        //}

        //public IEnumerable<Player> EnumerateAll() { return _repo.Enumerate(); }
    }
}