namespace ekscarMVC.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editmaintenance : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cars", newName: "Maintenances");
            AddColumn("dbo.Maintenances", "Description", c => c.String());
            DropColumn("dbo.Maintenances", "FirstDate");
            DropColumn("dbo.Maintenances", "UpdateDate");
            DropColumn("dbo.Maintenances", "IsActive");
            DropColumn("dbo.Maintenances", "IsDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Maintenances", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Maintenances", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Maintenances", "UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Maintenances", "FirstDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Maintenances", "Description");
            RenameTable(name: "dbo.Maintenances", newName: "Cars");
        }
    }
}
