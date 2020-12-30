using System;
using System.Threading.Tasks;
using DeliveryService.Services.Availability.Core.Entities;

namespace DeliveryService.Services.Availability.Core.Repositories
{
    public interface IResourcesRepository
    {
        Task<Resource> GetAsync(AggregateId id);
        Task UpdateAsync(Resource resource);
        Task AddAsync(Resource resource);
        Task DeleteAsync(AggregateId id);
    }
}