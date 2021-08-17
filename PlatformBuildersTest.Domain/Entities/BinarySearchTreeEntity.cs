using MongoDB.Bson.Serialization.Attributes;
using PlatformBuildersTest.Domain.Entities.Base;
using System.Collections.Generic;

namespace PlatformBuildersTest.Domain.Entities
{
    public class BinarySearchTreeEntity
    {
        public IEnumerable<BinarySearchTreeNodeEntity> Tree { get; set; } = new List<BinarySearchTreeNodeEntity>();
    }

    public class BinarySearchTreeNodeEntity : BaseEntity
    {
        public BinarySearchTreeNodeEntity()
        {
        }
        public BinarySearchTreeNodeEntity(int value)
        {
            Value = value;
        }

        [BsonIgnoreAttribute]
        public int Value 
        {
            get => Id;
            set => Id = value;
        }
        public int Parent { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
    }
}
