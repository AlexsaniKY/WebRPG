using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Interfaces;
using WebApplication1.Domain.Items;

namespace WebApplication1.Domain.Creature
{
    public abstract class Creature: IActivatable, IDbEntity//, IInventory
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        //public virtual ICollection<Item> Items { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public abstract string CreatureType { get; }

        
        public int WieldedWeaponId { get; set; }
        [ForeignKey("WieldedWeaponId")]
        public virtual Weapon WieldedWeapon { get; set; }

        public int HP { get; set; }

        
        public int FactionId { get; set; }
        [ForeignKey("FactionId")]
        public virtual Faction ParentFaction { get; set; }

        public Creature() { }
        public Creature(int id, bool active, string name, int hp, int wieldedweaponid, int factionid )
        {
            Id = id;
            Active = active;
            Name = name;
            HP = hp;
            WieldedWeaponId = wieldedweaponid;
            FactionId = factionid;
        }
    }
}