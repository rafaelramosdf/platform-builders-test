using PlatformBuildersTest.Domain.Entities.Base;
using System;
using System.Linq.Expressions;

namespace PlatformBuildersTest.Domain.Contracts.Repositories.Base
{
    public interface IReaderBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        TEntity Get(Expression<Func<TEntity, bool>> query);
        TEntity Get(int id);
    }
}
