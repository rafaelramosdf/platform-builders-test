using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlatformBuildersTest.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        [BsonId]
        public int Id { get; set; }
    }
}
