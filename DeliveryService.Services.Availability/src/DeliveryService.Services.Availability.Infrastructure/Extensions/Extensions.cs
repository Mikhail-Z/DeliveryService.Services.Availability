using System.Linq;
using DeliveryService.Services.Availability.Core.Entities;
using DeliveryService.Services.Availability.Core.ValueObjects;
using DeliveryService.Services.Availability.Infrastructure.Mongo.Documents;

namespace DeliveryService.Services.Availability.Infrastructure.Extensions
{
    public static class Extensions
    {
        public static Resource AsEntity(this ResourceDocument resourceDocument)
            => new Resource(
                resourceDocument.Id,
                resourceDocument.Tags, 
                resourceDocument.Reservations?.Select(rd => new Reservation(rd.DateTime, rd.Priority)),
                resourceDocument.Version);

        public static ResourceDocument AsDocument(this Resource resource)
            => new ResourceDocument
            {
                Id = resource.Id,
                Reservations = resource.Reservations?.Select(r => new ReservationDocument(r.DateTime, r.Priority)),
                Tags = resource.Tags,
                Version = resource.Version
            };
    }
}