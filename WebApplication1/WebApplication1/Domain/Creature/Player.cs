using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Domain.Creature
{
    public class Player: Creature
    {
        public Player(int id, bool active, string name, int hp, int wieldeditemid, int factionid) : base(id, active, name, hp, wieldeditemid, factionid)
        {
        }

        public override string CreatureType { get; } = "Player";
    }
}