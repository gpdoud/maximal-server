namespace Maxtrain.Maximal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createrelationshipsbetweenuserroleprivilege : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Privileges", "Name", c => c.String());
            AddColumn("dbo.Privileges", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Privileges", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Privileges", "DateUpdated", c => c.DateTime());
            AddColumn("dbo.Roles", "Name", c => c.String());
            AddColumn("dbo.Roles", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Roles", "DateUpdated", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Roles", "DateUpdated");
            DropColumn("dbo.Roles", "DateCreated");
            DropColumn("dbo.Roles", "Active");
            DropColumn("dbo.Roles", "Name");
            DropColumn("dbo.Privileges", "DateUpdated");
            DropColumn("dbo.Privileges", "DateCreated");
            DropColumn("dbo.Privileges", "Active");
            DropColumn("dbo.Privileges", "Name");
        }
    }
}
