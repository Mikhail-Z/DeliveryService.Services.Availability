using System.Threading.Tasks;
using DeliveryService.Services.Availability.Core.Entities;
using DeliveryService.Services.Availability.Core.Repositories;

namespace DeliveryService.Services.Availability.Infrastructure.Mongo.Repositories
{
    internal sealed class ResourcesMongoRepository : IResourcesRepository
    {
        public Task<Resource> GetAsync(AggregateId id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Resource resource)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAsync(Resource resource)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(AggregateId id)
        {
            throw new System.NotImplementedException();
        }
    }
}