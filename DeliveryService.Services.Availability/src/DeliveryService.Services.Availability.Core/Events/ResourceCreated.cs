using DeliveryService.Services.Availability.Core.Entities;

namespace DeliveryService.Services.Availability.Core.Events
{
    public class ResourceCreated : IDomainEvent
    {
        public Resource Resource { get; }

        public ResourceCreated(Resource resource)
        {
            Resource = resource;
        }
    }
}