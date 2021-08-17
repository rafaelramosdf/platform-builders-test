using MongoDB.Driver;
using PlatformBuildersTest.Domain.Contracts.Repositories.Base;
using PlatformBuildersTest.Domain.Entities.Base;
using PlatformBuildersTest.Domain.Objects;
using System;
using System.Linq.Expressions;

namespace PlatformBuildersTest.Infra.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly IMongoCollection<TEntity> _bts;

        public BaseRepository(IMongoDbSettingsObject settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _bts = database.GetCollection<TEntity>(settings.CollectionName);
        }

        public void Add(TEntity obj)
        {
            _bts.InsertOne(obj);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> query)
        {
            return _bts.Find(query).FirstOrDefault();
        }

        public TEntity Get(int id)
        {
            return _bts.Find(bts => bts.Id == id).FirstOrDefault();
        }

        public void Remove(TEntity obj)
        {
            _bts.DeleteOne(bts => bts.Id == obj.Id);
        }
    }
}
