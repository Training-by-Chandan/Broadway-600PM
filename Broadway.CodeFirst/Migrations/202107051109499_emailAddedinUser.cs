namespace Broadway.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class emailAddedinUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String());
            DropColumn("dbo.Teachers", "Email");
            DropColumn("dbo.Students", "Email");
        }

        public override void Down()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
            AddColumn("dbo.Teachers", "Email", c => c.String());
            DropColumn("dbo.Users", "Email");
        }
    }
}