namespace Smsproz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacherattendenceadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeacherAttendences", "GetDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.TeacherAttendences", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeacherAttendences", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.TeacherAttendences", "GetDateTime");
        }
    }
}
