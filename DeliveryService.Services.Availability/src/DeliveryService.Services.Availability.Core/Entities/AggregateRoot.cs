using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DeliveryService.Services.Availability.Core.Events;

namespace DeliveryService.Services.Availability.Core.Entities
{
    /**
     * Доменный объект -- соответствует событию, которое произошло в системе
     */
    public class AggregateRoot
    {
        private readonly IList<IDomainEvent> _events = new List<IDomainEvent>();
        
        public AggregateId Id { get; protected set; }

        public int Version { get; protected set; }
        public IEnumerable<IDomainEvent> Events => _events;

        public void AddEvent(IDomainEvent @event)
        {
            if (!_events.Any()) Version++;

            _events.Add(@event);
        }

        public void Clear() => _events.Clear();
    }
}