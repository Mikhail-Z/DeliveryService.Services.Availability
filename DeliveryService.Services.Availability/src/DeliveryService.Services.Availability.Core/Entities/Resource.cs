using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DeliveryService.Services.Availability.Core.Events;
using DeliveryService.Services.Availability.Core.Exceptions;
using DeliveryService.Services.Availability.Core.ValueObjects;

namespace DeliveryService.Services.Availability.Core.Entities
{
    /// <summary>
    /// Объект этого класса можно резервировать при осуществлении чего-либо, является самым абстрактным
    /// </summary>
    public class Resource : AggregateRoot
    {
        private ISet<string> _tags = new HashSet<string>();
        private ISet<Reservation> _reservations = new HashSet<Reservation>();

        public ISet<string> Tags
        {
            get => _tags;
            private set => _tags = new HashSet<string>();
        }

        public ISet<Reservation> Reservations
        {
            get => _reservations;
            private set => _reservations = new HashSet<Reservation>();
        }

        public Resource(AggregateId id, ISet<string> tags, IEnumerable<Reservation> resevations = null, int version = 0)
        {
            Id = id;
            Tags = tags;
            Reservations = resevations;
            Version = version;
        }

        private static void ValidateTags(IEnumerable<string> tags)
        {
            if (tags == null || !tags.Any())
            {
                throw new MissingResourceTagsException();
            }

            if (tags.Any(tag => String.IsNullOrWhiteSpace(tag)))
            {
                throw new InvalidResourceTagsException();
            }
        }

        public static Resource Create(AggregateId id, ISet<string> tags, ISet<Reservation> resevations = null)
        {
            var resource = new Resource(id, tags, resevations);
            resource.AddEvent(new ResourceCreated(resource));

            return resource;
        }
    }
}