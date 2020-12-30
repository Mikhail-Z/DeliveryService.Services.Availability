using System;

namespace DeliveryService.Services.Availability.Core.Entities
{
    /// <summary>
    /// Базовый класс для всех сущностей (Entities)
    /// </summary>
    public class AggregateId : IEquatable<AggregateId>
    {
        public Guid Value { get; }

        public AggregateId() : this(Guid.NewGuid())
        {
            
        }
        
        public AggregateId(Guid value)
        {
            if (value == Guid.Empty) throw new ArgumentException("value can't have default value", nameof(value));
            
            Value = value;
        }

        public bool Equals(AggregateId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((AggregateId) obj);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public static implicit operator Guid(AggregateId aggregateId) => aggregateId.Value;

        public static implicit operator AggregateId(Guid guid) => new AggregateId(guid);
    }
}