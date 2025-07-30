using clean_architecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.infastrcured.persistnace
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ValueTask<TEntity> IRepository<TEntity>.AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        ValueTask<TEntity> IRepository<TEntity>.DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        ValueTask<IEnumerable<TEntity>> IRepository<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        ValueTask<TEntity> IRepository<TEntity>.GetEntityById<T>(T id)
        {
            throw new NotImplementedException();
        }

        ValueTask<TEntity> IRepository<TEntity>.UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
