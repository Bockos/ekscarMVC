namespace ekscarMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false, maxLength: 250),
                        Mail = c.String(nullable: false, maxLength: 250),
                        Photo = c.String(maxLength: 250),
                        RecoveryKey = c.String(maxLength: 100),
                        IsConfirmed = c.String(maxLength: 10),
                        LastLoginDate = c.String(maxLength: 20),
                        FirstDate = c.String(maxLength: 20),
                        UpdateDate = c.String(maxLength: 20),
                        IsActive = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
