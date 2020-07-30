using Infantes.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infantes.Database
{

    public class Repository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }

        public TEntity Delete(TEntity entity)
        {
            var record = _context.Set<TEntity>().Find(entity.Id);
            if (record != null)
            {
                _context.Set<TEntity>().Remove(record);
                _context.SaveChanges();
            }

            return record;
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);

        }

        public DbSet<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

            return entity;
        }
    }
}
