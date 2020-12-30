using Convey;
using Convey.CQRS.Commands;
using Convey.CQRS.Events;
using Convey.CQRS.Queries;

namespace DeliveryService.Services.Availability.Application.Extensions
{
    public static class BaseExtensions
    {
        public static IConveyBuilder AddApplication(this IConveyBuilder builder) 
            => builder
                .AddCommandHandlers()
                .AddEventHandlers()
                .AddInMemoryCommandDispatcher()
                .AddInMemoryQueryDispatcher();
    }
}