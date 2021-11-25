﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Registration.Core.Entity
{
    public class Entity<TKey> : IEntity<TKey> where TKey : IEquatable<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }


    public class Entity : Entity<Guid>, IEntity
    {

    }
}