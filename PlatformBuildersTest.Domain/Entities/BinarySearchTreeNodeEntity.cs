using MongoDB.Bson.Serialization.Attributes;
using PlatformBuildersTest.Domain.Entities.Base;

namespace PlatformBuildersTest.Domain.Entities
{
    public class BinarySearchTreeNodeEntity : BaseEntity
    {
        public BinarySearchTreeNodeEntity()
        {
        }
        public BinarySearchTreeNodeEntity(int value)
        {
            Value = value;
        }

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
