using System;

namespace DeliveryService.Services.Availability.Core.ValueObjects
{
    /// <summary>
    /// обычная практика делать value objects структурами, так как  
    /// </summary>
    public struct Reservation
    {
        public DateTime DateTime { get; }
        public int Priority { get; }

        public Reservation(DateTime dateTime, int priority)
        {
            DateTime = dateTime;
            Priority = priority;
        }
    }
}