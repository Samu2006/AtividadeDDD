using FluentValidator;
using System;

namespace PC2.Shared.Entities
{
    public abstract class Entity : Notifiable
    {

        public Entity()
        {
            Id = Guid.NewGuid();
            CreateAt = DateTime.Now;
        }

        public Entity(Guid id, DateTime createAt)
        {
            Id = id;
            CreateAt = createAt;
        }

        public Guid Id { get; private set; }
        public DateTime CreateAt { get; private set; }
    }
}
