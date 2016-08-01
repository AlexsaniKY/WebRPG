using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Services.DTO;

namespace WebApplication1.Domain.Items
{
    public class Weapon: Item
    {
        public int Damage { get; set; }
        public Weapon() : base() { }
        public Weapon(WeaponDTO weapon_dto): base(weapon_dto.Id, weapon_dto.Active, weapon_dto.Name)
        {
            Damage = weapon_dto.Damage;
        }
    }
}