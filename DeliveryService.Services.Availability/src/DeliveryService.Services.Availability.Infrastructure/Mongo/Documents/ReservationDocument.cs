using System;

namespace DeliveryService.Services.Availability.Infrastructure.Mongo.Documents
{
    internal sealed class ReservationDocument
    {
        public ReservationDocument(DateTime dateTime, int priority)
        {
            DateTime = dateTime;
            Priority = priority;
        }
        
        public DateTime DateTime { get; set; }
        public int Priority { get; set; }
    }
}