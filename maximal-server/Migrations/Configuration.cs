namespace Maxtrain.Maximal.Migrations
{
    using Maxtrain.Maximal.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Maxtrain.Maximal.Models.MaximalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Maxtrain.Maximal.Models.MaximalDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate<User>(u =>
                u.Username, (
                    new User {
                        Username = "sa",
                        Password = "sa",
                        Firstname = "Max",
                        Lastname = "Admin",
                        Email = "gdoud@maxtrain.com",
                        Phone = "513-703-7315",
                        Active = true
                    }
               )
            );
            context.Roles.AddOrUpdate<Role>(r =>
                r.Code, (
                    new Role {
                        Code = "SYSA",
                        Name = "System Administrator"
                    }
                )
            );
            context.Privileges.AddOrUpdate<Privilege>(p =>
                p.Code, (
                    new Privilege {
                        Code = "FULL",
                        Name = "Full Admin Access"
                    }
                )
            );
            context.UserRoleRels.AddOrUpdate<UserRoleRel>(ur =>
                new { ur.UserId, ur.RoleId }, (
                    new UserRoleRel {
                        UserId = context.Users.Single(u => u.Username == "sa").Id,
                        RoleId = context.Roles.Single(r => r.Code == "SYSA").Id
                    }
                )
            );
            context.RolePrivilegeRels.AddOrUpdate<RolePrivilegeRel>(rp =>
                new { rp.RoleId, rp.PrivilegeId }, (
                    new RolePrivilegeRel {
                        RoleId = context.Roles.Single(r => r.Code == "SYSA").Id,
                        PrivilegeId = context.Privileges.Single(p => p.Code == "FULL").Id
                    }
                )
            );
        }
    }
}
