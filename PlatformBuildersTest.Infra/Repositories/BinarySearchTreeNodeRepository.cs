using PlatformBuildersTest.Domain.Contracts.Repositories;
using PlatformBuildersTest.Domain.Entities;
using System.Collections.Generic;

namespace PlatformBuildersTest.Infra.Repositories
{
    public class BinarySearchTreeNodeRepository : IBinarySearchTreeNodeRepository
    {
        public BinarySearchTreeNodeEntity Get(int value)
        {
            // TODO: A Implementar
            return new BinarySearchTreeNodeEntity(50);
        }
    }
}
