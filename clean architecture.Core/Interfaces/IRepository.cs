using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ValueTask<IEnumerable< TEntity>> GetAll();
        ValueTask<TEntity> AddAsync(TEntity entity);
        ValueTask<TEntity> UpdateAsync(TEntity entity);
        ValueTask<TEntity> DeleteAsync(TEntity entity);
        ValueTask<TEntity> GetEntityById<T>(T id);
    }
}
