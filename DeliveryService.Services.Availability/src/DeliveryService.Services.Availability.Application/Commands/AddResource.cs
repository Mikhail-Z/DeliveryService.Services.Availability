using System;
using System.Collections;
using System.Collections.Generic;
using Convey.CQRS.Commands;
using DeliveryService.Services.Availability.Core.Entities;

namespace DeliveryService.Services.Availability.Application.Commands
{
    public class AddResource : AggregateRoot, ICommand
    {
        public Guid ResourceId { get; }
        public ISet<string> Tags { get; }
    }
}