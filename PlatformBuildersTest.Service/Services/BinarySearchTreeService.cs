using PlatformBuildersTest.Domain.Contracts.Repositories;
using PlatformBuildersTest.Domain.Contracts.Services;
using PlatformBuildersTest.Domain.Entities;

namespace PlatformBuildersTest.Service.Services
{
    public class BinarySearchTreeService : IBinarySearchTreeService
    {
        private readonly IBinarySearchTreeNodeRepository _btsRepository;

        public BinarySearchTreeService(IBinarySearchTreeNodeRepository btsRepository)
        {
            _btsRepository = btsRepository;
        }

        public BinarySearchTreeNodeEntity Add(BinarySearchTreeNodeEntity entity)
        {
            _btsRepository.Add(entity);
            return entity;
        }

        public void Remove(BinarySearchTreeNodeEntity entity)
        {
            _btsRepository.Remove(entity);
        }

        public BinarySearchTreeNodeEntity Get(int value)
        {
            return _btsRepository.Get(value);
        }
    }
}
