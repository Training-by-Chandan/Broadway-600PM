namespace Broadway.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Classes", "UserId", "dbo.Users");
            DropIndex("dbo.Classes", new[] { "UserId" });
            AddColumn("dbo.Students", "UserId", c => c.Int());
            CreateIndex("dbo.Students", "UserId");
            AddForeignKey("dbo.Students", "UserId", "dbo.Users", "Id");
            DropColumn("dbo.Classes", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Classes", "UserId", c => c.Int());
            DropForeignKey("dbo.Students", "UserId", "dbo.Users");
            DropIndex("dbo.Students", new[] { "UserId" });
            DropColumn("dbo.Students", "UserId");
            CreateIndex("dbo.Classes", "UserId");
            AddForeignKey("dbo.Classes", "UserId", "dbo.Users", "Id");
        }
    }
}
