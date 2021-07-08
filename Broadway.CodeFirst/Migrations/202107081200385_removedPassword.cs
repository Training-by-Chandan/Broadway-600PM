namespace Broadway.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedPassword : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "PlainPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "PlainPassword", c => c.String());
        }
    }
}
