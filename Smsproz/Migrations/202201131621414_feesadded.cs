namespace Smsproz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feesadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fees",
                c => new
                    {
                        FeesId = c.Int(nullable: false, identity: true),
                        ClaId = c.Int(nullable: false),
                        FeesAmount = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FeesId)
                .ForeignKey("dbo.clas", t => t.ClaId, cascadeDelete: true)
                .Index(t => t.ClaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fees", "ClaId", "dbo.clas");
            DropIndex("dbo.Fees", new[] { "ClaId" });
            DropTable("dbo.Fees");
        }
    }
}
