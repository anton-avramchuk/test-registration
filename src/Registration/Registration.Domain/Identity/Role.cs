using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Registration.Core.Entity;

namespace Registration.Domain.Identity
{
    public class Role : IdentityRole<Guid>, IEntity
    {

        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }
        public ICollection<UserRole> UserRoles { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }
    }
}