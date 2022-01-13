namespace Smsproz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subjectadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        ClaId = c.Int(nullable: false),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.clas", t => t.ClaId, cascadeDelete: true)
                .Index(t => t.ClaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "ClaId", "dbo.clas");
            DropIndex("dbo.Subjects", new[] { "ClaId" });
            DropTable("dbo.Subjects");
        }
    }
}
