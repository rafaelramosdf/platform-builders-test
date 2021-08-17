using PlatformBuildersTest.Domain.Contracts.Repositories;
using PlatformBuildersTest.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PlatformBuildersTest.Infra
{
    public class SeedData
    {
        private readonly IBinarySearchTreeNodeRepository _btsRepository;

        public SeedData(IBinarySearchTreeNodeRepository btsRepository)
        {
            _btsRepository = btsRepository;
        }

        public void InitializeDb()
        {
            foreach (var item in BinarySearchTreeNodeSeddData.Documents)
            {
                if(!_btsRepository.GetMany(b => b.Id == item.Id).Any())
                {
                    _btsRepository.Add(item);
                }
            }
        }
    }

    public static class BinarySearchTreeNodeSeddData
    {
        public static IEnumerable<BinarySearchTreeNodeEntity> Documents => new List<BinarySearchTreeNodeEntity> 
        {
            new BinarySearchTreeNodeEntity(70, 60, 69, 71),
            new BinarySearchTreeNodeEntity(60, 50, 59, 70),
            new BinarySearchTreeNodeEntity(50, 0, 40, 60),
            new BinarySearchTreeNodeEntity(40, 50, 30, 41),
            new BinarySearchTreeNodeEntity(30, 40, 20, 31),
            new BinarySearchTreeNodeEntity(20, 30, 10, 21)
        };
    }
}
