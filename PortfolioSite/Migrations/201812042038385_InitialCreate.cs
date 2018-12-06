namespace PortfolioSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        VisitorID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.VisitorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitors");
        }
    }
}
