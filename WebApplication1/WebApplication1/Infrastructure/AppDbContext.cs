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
        public AppDbContext() : base("AppDbContext") { }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
        //Creatures
        DbSet<Monster> Monsters { get; set; }
        DbSet<Player>Players { get; set; }
        //Items
        DbSet<Potion>Potions { get; set; }
        DbSet<Weapon>Weapons { get; set; }
        //Locations
        DbSet <City> Cities { get; set; }
        DbSet<Road> Roads { get; set; }

        DbSet<Faction> Factions { get; set; }

    }
}