using System;
using System.Collections.Generic;

namespace DeliveryService.Services.Availability.Infrastructure.Mongo.Documents
{
    public sealed class ResourceDocument 
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public ISet<string> Tags { get; set; }
        public IEnumerable<ReservationDocument> Reservations { get; set; }
    }
}