namespace Maxtrain.Maximal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Privileges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 30),
                        Firstname = c.String(maxLength: 30),
                        Lastname = c.String(nullable: false, maxLength: 30),
                        Email = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 30),
                        LastPasswordChange = c.DateTime(),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true, name: "UIDX_Username");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", "UIDX_Username");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Privileges");
        }
    }
}
