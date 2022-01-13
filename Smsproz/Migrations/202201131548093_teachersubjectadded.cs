namespace Smsproz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teachersubjectadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherSubjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        claId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.clas", t => t.claId, cascadeDelete: true)
                .Index(t => t.claId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherSubjects", "claId", "dbo.clas");
            DropIndex("dbo.TeacherSubjects", new[] { "claId" });
            DropTable("dbo.TeacherSubjects");
        }
    }
}
