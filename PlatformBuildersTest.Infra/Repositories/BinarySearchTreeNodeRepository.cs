using PlatformBuildersTest.Domain.Contracts.Repositories;
using PlatformBuildersTest.Domain.Entities;
using PlatformBuildersTest.Domain.Objects;
using PlatformBuildersTest.Infra.Repositories.Base;

namespace PlatformBuildersTest.Infra.Repositories
{
    public class BinarySearchTreeNodeRepository : BaseRepository<BinarySearchTreeNodeEntity>, IBinarySearchTreeNodeRepository
    {
        private readonly IMongoDbSettingsObject _mongoDbSettings;

        public BinarySearchTreeNodeRepository(IMongoDbSettingsObject mongoDbSettings)
            : base(mongoDbSettings)
        {
        }
    }
}
