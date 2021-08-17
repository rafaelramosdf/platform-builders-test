namespace PlatformBuildersTest.Domain.Objects
{
    public class MongoDbSettingsObject : IMongoDbSettingsObject
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string CollectionName { get; set; }
    }

    public interface IMongoDbSettingsObject
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string CollectionName { get; set; }
    }
}
