using System;

namespace DeliveryService.Services.Availability.Application.Exceptions
{
    public class ApplicationException : Exception
    {
        public ApplicationException(string message) : base(message) {}
    }
}