namespace ekscarMVC.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editmaintenance1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Maintenances", "City_Id", c => c.Int());
            AddColumn("dbo.Maintenances", "Region_Id", c => c.Int());
            CreateIndex("dbo.Maintenances", "City_Id");
            CreateIndex("dbo.Maintenances", "Region_Id");
            AddForeignKey("dbo.Maintenances", "City_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Maintenances", "Region_Id", "dbo.Regions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Maintenances", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.Maintenances", "City_Id", "dbo.Cities");
            DropIndex("dbo.Maintenances", new[] { "Region_Id" });
            DropIndex("dbo.Maintenances", new[] { "City_Id" });
            DropColumn("dbo.Maintenances", "Region_Id");
            DropColumn("dbo.Maintenances", "City_Id");
        }
    }
}
