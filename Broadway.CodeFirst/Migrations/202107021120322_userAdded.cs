namespace Broadway.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        PlainPassword = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Classes", "UserId", c => c.Int());
            AddColumn("dbo.Teachers", "UserId", c => c.Int());
            CreateIndex("dbo.Classes", "UserId");
            CreateIndex("dbo.Teachers", "UserId");
            AddForeignKey("dbo.Teachers", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Classes", "UserId", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Teachers", "UserId", "dbo.Users");
            DropIndex("dbo.Teachers", new[] { "UserId" });
            DropIndex("dbo.Classes", new[] { "UserId" });
            DropColumn("dbo.Teachers", "UserId");
            DropColumn("dbo.Classes", "UserId");
            DropTable("dbo.Users");
        }
    }
}
