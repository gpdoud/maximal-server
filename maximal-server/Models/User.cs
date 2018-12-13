using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maxtrain.Maximal.Models {
    public class User {

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Index("UIDX_Username", IsUnique = true)]
        public string Username { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [StringLength(30)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }
        public DateTime? LastPasswordChange { get; set; } = null;

        public IEnumerable<Role> Roles { get; set; } = null;

        public bool Active { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; } = null;

        public User() { }
    }
}