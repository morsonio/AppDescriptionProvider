namespace ConsoleApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationEntities",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        ApplicationName = c.String(),
                        ApplicationDescription = c.String(),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApplicationEntities");
        }
    }
}
