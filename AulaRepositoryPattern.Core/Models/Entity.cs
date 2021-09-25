using System;

namespace AulaRepositoryPattern.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        protected Entity (Guid id)
        {
            Id = id;
        }
    }
}