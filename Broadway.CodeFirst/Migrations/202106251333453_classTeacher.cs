namespace Broadway.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class classTeacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "ClassId", c => c.Int());
            CreateIndex("dbo.Teachers", "ClassId");
            AddForeignKey("dbo.Teachers", "ClassId", "dbo.Classes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "ClassId", "dbo.Classes");
            DropIndex("dbo.Teachers", new[] { "ClassId" });
            DropColumn("dbo.Teachers", "ClassId");
        }
    }
}
