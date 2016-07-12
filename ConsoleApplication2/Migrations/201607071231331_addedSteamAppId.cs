namespace ConsoleApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedSteamAppId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationEntities", "ApplicationSteamAppId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplicationEntities", "ApplicationSteamAppId");
        }
    }
}
