namespace Smsproz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Examadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        ClaId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        RollNumber = c.String(),
                        TotalMarks = c.String(),
                        OutofMarks = c.String(),
                    })
                .PrimaryKey(t => t.ExamId)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "SubjectId", "dbo.Subjects");
            DropIndex("dbo.Exams", new[] { "SubjectId" });
            DropTable("dbo.Exams");
        }
    }
}
