using System;

namespace Registration.Core.Entity
{
    public class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
    }


    public class Entity : Entity<Guid>, IEntity
    {

    }
}