using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Domain;
using WebApplication1.Domain.Creature;
using WebApplication1.Domain.Items;
using WebApplication1.Domain.Locations;

namespace WebApplication1.Infrastructure
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base("AppDbContext") { Database.SetInitializer<AppDbContext>(null); }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
        //Creatures
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Player>Players { get; set; }
        //Items
        public DbSet<Potion>Potions { get; set; }
        public DbSet<Weapon>Weapons { get; set; }
        //Locations
        public DbSet <City> Cities { get; set; }
        public DbSet<Road> Roads { get; set; }

        public DbSet<Faction> Factions { get; set; }

        //public DbSet<Player> Players { get; set; }

        //public System.Data.Entity.DbSet<WebApplication1.Domain.Faction> Factions { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Domain.Items.Item> Items { get; set; }
    }
}