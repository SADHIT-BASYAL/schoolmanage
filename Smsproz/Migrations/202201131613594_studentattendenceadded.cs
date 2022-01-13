namespace Smsproz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentattendenceadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentAttendences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        RollNumber = c.String(),
                        Status = c.Boolean(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentAttendences");
        }
    }
}
