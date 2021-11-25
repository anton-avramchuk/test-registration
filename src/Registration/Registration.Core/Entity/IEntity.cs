using System;

namespace Registration.Core.Entity
{
    public interface IEntity<TKey> where TKey : IEquatable<TKey>
    {
        TKey Id { get; set; }
    }


    public interface IEntity : IEntity<Guid>
    {

    }
}