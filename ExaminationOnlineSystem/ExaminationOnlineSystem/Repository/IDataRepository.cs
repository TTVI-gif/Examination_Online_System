using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository
{
    public interface IDataRepository<TEntity>
    {
        Task<TEntity> AddAsync(TEntity entity);
        TEntity Update(TEntity entity);
        Task<IEnumerable<TResponse>> GetAllAsync<TResponse>(Expression<Func<TEntity, TResponse>> expression);
        Task<TEntity> GetByIdAsync(int id);
        TEntity Delete(TEntity entity);
    }
}
