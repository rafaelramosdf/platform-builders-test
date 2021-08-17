using PlatformBuildersTest.Domain.Entities;

namespace PlatformBuildersTest.Domain.Contracts.Services
{
    public interface IBinarySearchTreeService
    {
        BinarySearchTreeNodeEntity Get(int value);
    }
}
