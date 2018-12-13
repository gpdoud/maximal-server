using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maxtrain.Maximal.Models {
    public class RolePrivilegeRel {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PrivilegeId { get; set; }

        public bool Active { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; } = null;
    }
}