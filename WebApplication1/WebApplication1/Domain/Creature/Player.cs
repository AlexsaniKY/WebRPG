using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Items;
using WebApplication1.Services.DTO;

namespace WebApplication1.Domain.Creature
{
    public class Player: Creature
    {

        public Player():base() { }
        public Player(int id, bool active, string name, int hp, int wieldeditemid, int factionid) : base(id, active, name, hp, wieldeditemid, factionid)
        {
        }
        public Player(PlayerDTO dto) {
            Id = dto.Id;
            Active = dto.Active;
            Name = dto.Name;
            HP = dto.HP;
            WieldedWeaponId = dto.WieldedWeaponId;
            WieldedWeapon = new Weapon(dto.WieldedWeapon);
            FactionId = dto.FactionId;
        }
        public override string CreatureType { get; } = "Player";
    }
}