using Infantes.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infantes.Database
{
    public interface IRepository<TEntity>
        where TEntity : class, IEntity
    {
        DbSet<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Insert(TEntity entity);

    } 
}
