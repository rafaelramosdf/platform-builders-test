using PlatformBuildersTest.Domain.Entities;

namespace PlatformBuildersTest.Domain.Contracts.Services
{
    public interface IBinarySearchTreeService
    {
        BinarySearchTreeNodeEntity Add(BinarySearchTreeNodeEntity entity);
        void Remove(BinarySearchTreeNodeEntity entity);
        BinarySearchTreeNodeEntity Get(int value);
    }
}
