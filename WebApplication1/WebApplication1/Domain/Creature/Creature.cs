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
    public class Creature: IActivatable, IDbEntity, IInventory
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("WeildedItem")]
        public int WieldedItemId { get; set; }
        public virtual Item WieldedItem { get; set; }

        public int HP { get; set; }

        [ForeignKey("ParentFaction")]
        public int FactionId { get; set; }
        public virtual Faction ParentFaction { get; set; }
    }
}