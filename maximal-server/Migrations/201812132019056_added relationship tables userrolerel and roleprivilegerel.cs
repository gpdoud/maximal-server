namespace Maxtrain.Maximal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedrelationshiptablesuserrolerelandroleprivilegerel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RolePrivilegeRels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        PrivilegeId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoleRels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserRoleRels");
            DropTable("dbo.RolePrivilegeRels");
        }
    }
}
