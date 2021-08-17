using PlatformBuildersTest.Domain.Contracts.Repositories;
using PlatformBuildersTest.Domain.Contracts.Services;
using PlatformBuildersTest.Domain.Entities;

namespace PlatformBuildersTest.Service.Services
{
    public class BinarySearchTreeService : IBinarySearchTreeService
    {
        private readonly IBinarySearchTreeNodeRepository _binarySearchTreeNodeRepository;

        public BinarySearchTreeService(IBinarySearchTreeNodeRepository binarySearchTreeNodeRepository)
        {
            _binarySearchTreeNodeRepository = binarySearchTreeNodeRepository;
        }

        public BinarySearchTreeNodeEntity Get(int value)
        {
            return _binarySearchTreeNodeRepository.Get(value);
        }
    }
}
