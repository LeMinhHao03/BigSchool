namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCanceledColumnToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}
