using PlatformBuildersTest.Domain.Entities.Base;

namespace PlatformBuildersTest.Domain.Contracts.Repositories.Base
{
    public interface IBaseRepository<TEntity> : IWriterBaseRepository<TEntity>, IReaderBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
    }
}
