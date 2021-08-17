using System.Collections.Generic;

namespace PlatformBuildersTest.Domain.Entities
{
    public class BinarySearchTreeEntity
    {
        public IEnumerable<BinarySearchTreeNodeEntity> Tree { get; set; } = new List<BinarySearchTreeNodeEntity>();
    }

    public class BinarySearchTreeNodeEntity
    {
        public BinarySearchTreeNodeEntity()
        {
        }
        public BinarySearchTreeNodeEntity(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public BinarySearchTreeNodeEntity Parent { get; set; }
        public BinarySearchTreeNodeEntity Left { get; set; }
        public BinarySearchTreeNodeEntity Right { get; set; }
    }
}
