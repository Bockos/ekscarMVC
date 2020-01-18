namespace ekscarMVC.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CarModels", "CarBrandId", "dbo.CarBrands");
            DropForeignKey("dbo.Regions", "CityId", "dbo.Cities");
            CreateTable(
                "dbo.Maintenances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Year = c.String(nullable: false),
                        GearId = c.Int(nullable: false),
                        FuelId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarBrands", t => t.BrandId)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Regions", t => t.RegionId)
                .ForeignKey("dbo.CarFuelTypes", t => t.FuelId)
                .ForeignKey("dbo.CarGearTypes", t => t.GearId)
                .ForeignKey("dbo.CarModels", t => t.ModelId)
                .ForeignKey("dbo.CarTypes", t => t.TypeId)
                .Index(t => t.CityId)
                .Index(t => t.RegionId)
                .Index(t => t.BrandId)
                .Index(t => t.ModelId)
                .Index(t => t.TypeId)
                .Index(t => t.GearId)
                .Index(t => t.FuelId);
            
            CreateTable(
                "dbo.CarFuelTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        FirstDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarGearTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        FirstDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        FirstDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CarBrands", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CarModels", "FirstDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.CarModels", "UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.CarModels", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.CarModels", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CarModels", "CarGearType_Id", c => c.Int());
            AddColumn("dbo.Cities", "Plate", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Cities", "IsDeleted", c => c.Boolean(nullable: false));
            CreateIndex("dbo.CarModels", "CarGearType_Id");
            AddForeignKey("dbo.CarModels", "CarGearType_Id", "dbo.CarGearTypes", "Id");
            AddForeignKey("dbo.CarModels", "CarBrandId", "dbo.CarBrands", "Id");
            AddForeignKey("dbo.Regions", "CityId", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Regions", "CityId", "dbo.Cities");
            DropForeignKey("dbo.CarModels", "CarBrandId", "dbo.CarBrands");
            DropForeignKey("dbo.Maintenances", "TypeId", "dbo.CarTypes");
            DropForeignKey("dbo.Maintenances", "ModelId", "dbo.CarModels");
            DropForeignKey("dbo.Maintenances", "GearId", "dbo.CarGearTypes");
            DropForeignKey("dbo.CarModels", "CarGearType_Id", "dbo.CarGearTypes");
            DropForeignKey("dbo.Maintenances", "FuelId", "dbo.CarFuelTypes");
            DropForeignKey("dbo.Maintenances", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Maintenances", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Maintenances", "BrandId", "dbo.CarBrands");
            DropIndex("dbo.Maintenances", new[] { "FuelId" });
            DropIndex("dbo.Maintenances", new[] { "GearId" });
            DropIndex("dbo.Maintenances", new[] { "TypeId" });
            DropIndex("dbo.Maintenances", new[] { "ModelId" });
            DropIndex("dbo.Maintenances", new[] { "BrandId" });
            DropIndex("dbo.Maintenances", new[] { "RegionId" });
            DropIndex("dbo.Maintenances", new[] { "CityId" });
            DropIndex("dbo.CarModels", new[] { "CarGearType_Id" });
            DropColumn("dbo.Cities", "IsDeleted");
            DropColumn("dbo.Cities", "Plate");
            DropColumn("dbo.CarModels", "CarGearType_Id");
            DropColumn("dbo.CarModels", "IsDeleted");
            DropColumn("dbo.CarModels", "IsActive");
            DropColumn("dbo.CarModels", "UpdateDate");
            DropColumn("dbo.CarModels", "FirstDate");
            DropColumn("dbo.CarBrands", "IsDeleted");
            DropTable("dbo.CarTypes");
            DropTable("dbo.CarGearTypes");
            DropTable("dbo.CarFuelTypes");
            DropTable("dbo.Maintenances");
            AddForeignKey("dbo.Regions", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CarModels", "CarBrandId", "dbo.CarBrands", "Id", cascadeDelete: true);
        }
    }
}
