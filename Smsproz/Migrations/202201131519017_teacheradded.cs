namespace Smsproz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacheradded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(nullable: false),
                        DOB = c.String(),
                        Gender = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
        }
    }
}
