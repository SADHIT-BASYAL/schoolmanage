namespace Smsproz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        Mobile = c.String(nullable: false),
                        RollNumber = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        claId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.clas", t => t.claId, cascadeDelete: true)
                .Index(t => t.claId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "claId", "dbo.clas");
            DropIndex("dbo.Students", new[] { "claId" });
            DropTable("dbo.Students");
        }
    }
}
