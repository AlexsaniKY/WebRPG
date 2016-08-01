using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain;
using WebApplication1.Domain.Items;

namespace WebApplication1.Services.DTO
{
    public class PlayerDTO
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string CreatureType { get; set; }
        public int WieldedWeaponId { get; set; }
        public int HP { get; set; }
        public int FactionId { get; set; }
        public Faction ParentFaction { get; set; }
        public WeaponDTO WieldedWeapon { get; set; }

    }
}