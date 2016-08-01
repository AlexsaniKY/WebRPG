namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createddtosandchangedcreaturesWieldedItemtoWieldedWeapon : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Monsters", name: "WieldedItemId", newName: "WieldedWeaponId");
            RenameColumn(table: "dbo.Players", name: "WieldedItemId", newName: "WieldedWeaponId");
            RenameIndex(table: "dbo.Monsters", name: "IX_WieldedItemId", newName: "IX_WieldedWeaponId");
            RenameIndex(table: "dbo.Players", name: "IX_WieldedItemId", newName: "IX_WieldedWeaponId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Players", name: "IX_WieldedWeaponId", newName: "IX_WieldedItemId");
            RenameIndex(table: "dbo.Monsters", name: "IX_WieldedWeaponId", newName: "IX_WieldedItemId");
            RenameColumn(table: "dbo.Players", name: "WieldedWeaponId", newName: "WieldedItemId");
            RenameColumn(table: "dbo.Monsters", name: "WieldedWeaponId", newName: "WieldedItemId");
        }
    }
}
