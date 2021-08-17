using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlatformBuildersTest.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public virtual int Id { get; set; }
    }
}
