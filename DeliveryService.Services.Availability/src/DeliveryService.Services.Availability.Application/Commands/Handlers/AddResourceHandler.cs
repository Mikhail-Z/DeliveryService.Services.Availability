using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Convey.CQRS.Commands;
using DeliveryService.Services.Availability.Application.Exceptions;
using DeliveryService.Services.Availability.Core.Entities;
using DeliveryService.Services.Availability.Core.Repositories;

namespace DeliveryService.Services.Availability.Application.Commands.Handlers
{
    internal sealed class AddResourceHandler : ICommandHandler<AddResource>
    {
        private readonly IResourcesRepository _resourcesRepository;

        public AddResourceHandler(IResourcesRepository resourcesRepository)
        {
            _resourcesRepository = resourcesRepository;
        }        
        
        public async Task HandleAsync(AddResource command)
        {
            var resource = await _resourcesRepository.GetAsync(command.ResourceId);
            if (resource is {})
            {
                throw new ResourceAlreadyExistsException(command.ResourceId);
            }

            var newResource = Resource.Create(command.ResourceId, command.Tags);
            await _resourcesRepository.AddAsync(newResource);
        }
    }
}