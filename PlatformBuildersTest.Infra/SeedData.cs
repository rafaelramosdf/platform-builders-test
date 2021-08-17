using MongoDB.Driver;
using PlatformBuildersTest.Domain.Entities;
using PlatformBuildersTest.Domain.Objects;

namespace PlatformBuildersTest.Infra
{
    public class SeedData
    {
        private readonly IMongoCollection<BinarySearchTreeNodeEntity> _bts;

        public SeedData(IMongoDbSettingsObject settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _bts = database.GetCollection<BinarySearchTreeNodeEntity>(settings.CollectionName);
        }

        public void InitializeDb()
        {
        }
    }
}
