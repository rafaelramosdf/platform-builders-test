using PlatformBuildersTest.Domain.Entities;
using System.Collections.Generic;

namespace PlatformBuildersTest.Domain.Contracts.Repositories
{
    public interface IBinarySearchTreeNodeRepository
    {
        BinarySearchTreeNodeEntity Get(int value);
    }
}
