using System.Collections.Generic;

namespace Project_Model_DDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
    }
}