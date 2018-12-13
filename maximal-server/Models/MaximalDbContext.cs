using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Maxtrain.Maximal.Models {

    public class MaximalDbContext : DbContext {

        public MaximalDbContext() : base("name = MaximalDb") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<UserRoleRel> UserRoleRels { get; set; }
        public DbSet<RolePrivilegeRel> RolePrivilegeRels { get; set; }
    }
}