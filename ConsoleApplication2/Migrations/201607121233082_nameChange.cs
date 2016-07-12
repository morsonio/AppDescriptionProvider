namespace ConsoleApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameChange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        ApplicationName = c.String(nullable: false),
                        ApplicationSteamAppId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
            CreateTable(
                "dbo.Descriptions",
                c => new
                    {
                        DescriptionId = c.Int(nullable: false, identity: true),
                        DescriptionLanguage = c.Int(nullable: false),
                        DescriptionContent = c.String(),
                        Application_ApplicationId = c.Int(),
                    })
                .PrimaryKey(t => t.DescriptionId)
                .ForeignKey("dbo.Applications", t => t.Application_ApplicationId)
                .Index(t => t.Application_ApplicationId);
            
            DropTable("dbo.ApplicationEntities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ApplicationEntities",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        ApplicationName = c.String(nullable: false),
                        ApplicationDescription = c.String(),
                        ApplicationSteamAppId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
            DropForeignKey("dbo.Descriptions", "Application_ApplicationId", "dbo.Applications");
            DropIndex("dbo.Descriptions", new[] { "Application_ApplicationId" });
            DropTable("dbo.Descriptions");
            DropTable("dbo.Applications");
        }
    }
}
