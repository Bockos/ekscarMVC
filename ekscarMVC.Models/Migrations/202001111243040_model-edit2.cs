namespace ekscarMVC.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modeledit2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CarModels", "CarBrandId", "dbo.CarBrands");
            DropForeignKey("dbo.Regions", "CityId", "dbo.Cities");
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Year = c.String(nullable: false),
                        GearId = c.Int(nullable: false),
                        FuelId = c.Int(nullable: false),
                        FirstDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarBrands", t => t.BrandId)
                .ForeignKey("dbo.CarFuelTypes", t => t.FuelId)
                .ForeignKey("dbo.CarGearTypes", t => t.GearId)
                .ForeignKey("dbo.CarModels", t => t.ModelId)
                .ForeignKey("dbo.CarTypes", t => t.TypeId)
                .Index(t => t.BrandId)
                .Index(t => t.ModelId)
                .Index(t => t.TypeId)
                .Index(t => t.GearId)
                .Index(t => t.FuelId);
            
            AddForeignKey("dbo.CarModels", "CarBrandId", "dbo.CarBrands", "Id");
            AddForeignKey("dbo.Regions", "CityId", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Regions", "CityId", "dbo.Cities");
            DropForeignKey("dbo.CarModels", "CarBrandId", "dbo.CarBrands");
            DropForeignKey("dbo.Cars", "TypeId", "dbo.CarTypes");
            DropForeignKey("dbo.Cars", "ModelId", "dbo.CarModels");
            DropForeignKey("dbo.Cars", "GearId", "dbo.CarGearTypes");
            DropForeignKey("dbo.Cars", "FuelId", "dbo.CarFuelTypes");
            DropForeignKey("dbo.Cars", "BrandId", "dbo.CarBrands");
            DropIndex("dbo.Cars", new[] { "FuelId" });
            DropIndex("dbo.Cars", new[] { "GearId" });
            DropIndex("dbo.Cars", new[] { "TypeId" });
            DropIndex("dbo.Cars", new[] { "ModelId" });
            DropIndex("dbo.Cars", new[] { "BrandId" });
            DropTable("dbo.Cars");
            AddForeignKey("dbo.Regions", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CarModels", "CarBrandId", "dbo.CarBrands", "Id", cascadeDelete: true);
        }
    }
}
