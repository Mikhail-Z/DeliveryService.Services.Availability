using System;

namespace DeliveryService.Services.Availability.Application.Exceptions
{
    public class ResourceAlreadyExistsException : ApplicationException
    {
        public ResourceAlreadyExistsException(Guid id) : base($"Ресурс {id} уже существует")
        {
            
        }
    }
}