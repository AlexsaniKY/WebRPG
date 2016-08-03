namespace WebApplication1.Migrations
{
    using Domain;
    using Domain.Creature;
    using Domain.Items;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Infrastructure.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Infrastructure.AppDbContext context)
        {
            context.Players.AddOrUpdate(p => p.Id,
                new Player() { Id = 1, Name = "Superman Viking", Active = true, FactionId = 1, HP = 50, WieldedWeaponId = 1 },
                new Player() { Id = 2, Name = "Someone Else", Active = true, FactionId = 2, HP = 30, WieldedWeaponId = 2 }
                );

            context.Items.AddOrUpdate(p => p.Id,
                new Weapon() { Id = 1, Active = true, Damage = 5, Name = "Sword" },
                new Weapon() { Id = 2, Active = true, Damage = 2, Name = "Spear" }
                );

            context.Factions.AddOrUpdate(p => p.Id,
                new Faction() { Id = 1, Active = true, Name = "Red team" },
                new Faction() { Id = 2, Active = true, Name = "Blutarch" }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
