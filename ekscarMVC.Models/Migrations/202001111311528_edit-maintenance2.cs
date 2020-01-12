namespace ekscarMVC.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editmaintenance2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Maintenances", new[] { "City_Id" });
            DropIndex("dbo.Maintenances", new[] { "Region_Id" });
            RenameColumn(table: "dbo.Maintenances", name: "City_Id", newName: "CityId");
            RenameColumn(table: "dbo.Maintenances", name: "Region_Id", newName: "RegionId");
            AlterColumn("dbo.Maintenances", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.Maintenances", "RegionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Maintenances", "CityId");
            CreateIndex("dbo.Maintenances", "RegionId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Maintenances", new[] { "RegionId" });
            DropIndex("dbo.Maintenances", new[] { "CityId" });
            AlterColumn("dbo.Maintenances", "RegionId", c => c.Int());
            AlterColumn("dbo.Maintenances", "CityId", c => c.Int());
            RenameColumn(table: "dbo.Maintenances", name: "RegionId", newName: "Region_Id");
            RenameColumn(table: "dbo.Maintenances", name: "CityId", newName: "City_Id");
            CreateIndex("dbo.Maintenances", "Region_Id");
            CreateIndex("dbo.Maintenances", "City_Id");
        }
    }
}
