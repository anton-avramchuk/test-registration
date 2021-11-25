using System;
using Microsoft.AspNetCore.Identity;
using Registration.Core.Entity;

namespace Registration.Domain.Identity
{
    public class User : IdentityUser<Guid>, IEntity
    {
        [ProtectedPersonalData]
        public string FirstName { get; set; }
        [ProtectedPersonalData]
        public string LastName { get; set; }
        [ProtectedPersonalData]
        public string FatherName { get; set; }

        public DateTime BirthDay { get; set; }

    }
}