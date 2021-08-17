using PlatformBuildersTest.Domain.Contracts.Repositories;
using PlatformBuildersTest.Domain.Entities;
using PlatformBuildersTest.Domain.Objects;
using PlatformBuildersTest.Infra.Repositories.Base;

namespace PlatformBuildersTest.Infra.Repositories
{
    public class BinarySearchTreeNodeRepository : BaseRepository<BinarySearchTreeNodeEntity>, IBinarySearchTreeNodeRepository
    {
        public BinarySearchTreeNodeRepository(IMongoDbSettingsObject mongoDbSettings)
            : base(mongoDbSettings)
        {
        }
    }
}
