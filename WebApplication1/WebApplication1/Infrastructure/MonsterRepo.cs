using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Creature;

namespace WebApplication1.Infrastructure
{
    public class MonsterRepo: GenericRepository<Monster>
    {
        public MonsterRepo(DbContext db) : base(db)
        {
        }

        public static bool HasMonster(int id)
        {
            throw new NotImplementedException();
        }

        public static bool AddMonster(Monster newMonster)
        {
            throw new NotImplementedException();
        }

        public static bool UpdateCreature(Creature alteredCreature)
        {
            throw new NotImplementedException();
        }

        public static bool DeleteCreature(int id)
        {
            throw new NotImplementedException();
        }

        public static Creature GetCreature(int id)
        {
            throw new NotImplementedException();
        }
    }
}