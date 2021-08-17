using PlatformBuildersTest.Domain.Entities.Base;
using System;

namespace PlatformBuildersTest.Domain.Contracts.Repositories.Base
{
    public interface IWriterBaseRepository<TEntity> 
        where TEntity : BaseEntity
    {
        void Add(TEntity obj);
        void Remove(TEntity obj);
    }
}
