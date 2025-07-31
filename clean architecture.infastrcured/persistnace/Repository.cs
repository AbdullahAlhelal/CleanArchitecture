using clean_architecture.Core.Interfaces;
using clean_architecture.infastrcured.persistnace.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.infastrcured.persistnace
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        ApplicationDbContext _context;
        DbSet<TEntity> _entity;
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            _entity = _context.Set<TEntity>();

        }
        public async ValueTask<TEntity> AddAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            return entity;
        }

        public async ValueTask<TEntity> DeleteAsync(TEntity entity)
        {
            return entity;
        }

        public async ValueTask<IEnumerable<TEntity>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public async ValueTask<TEntity> GetEntityById<T>(T id)
        {
            var entity = await _entity.FindAsync(id);
            return entity;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void UpdateAsync(TEntity entity)
        {
            _entity.Update(entity);

        }
    }
}
