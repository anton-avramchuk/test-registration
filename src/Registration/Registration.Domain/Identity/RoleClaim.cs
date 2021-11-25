using System;
using Microsoft.AspNetCore.Identity;
using Registration.Core.Entity;

namespace Registration.Domain.Identity
{
    public class RoleClaim : IdentityRoleClaim<Guid>, IEntity<int>
    {

    }
}