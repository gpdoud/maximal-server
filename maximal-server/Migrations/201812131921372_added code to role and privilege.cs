namespace Maxtrain.Maximal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcodetoroleandprivilege : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Privileges", "Code", c => c.String(nullable: false, maxLength: 6));
            AddColumn("dbo.Privileges", "Description", c => c.String());
            AddColumn("dbo.Roles", "Code", c => c.String(nullable: false, maxLength: 6));
            AddColumn("dbo.Roles", "Description", c => c.String());
            AlterColumn("dbo.Privileges", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Roles", "Name", c => c.String());
            AlterColumn("dbo.Privileges", "Name", c => c.String());
            DropColumn("dbo.Roles", "Description");
            DropColumn("dbo.Roles", "Code");
            DropColumn("dbo.Privileges", "Description");
            DropColumn("dbo.Privileges", "Code");
        }
    }
}
