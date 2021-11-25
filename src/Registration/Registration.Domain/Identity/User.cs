using System;
using Microsoft.AspNetCore.Identity;
using Registration.Core.Entity;

namespace Registration.Domain.Identity
{
    public class User : IdentityUser<Guid>, IEntity
    {

    }
}