using System.Linq.Expressions;
using Magz.CoreLayer.Entities;

namespace Magz.CoreLayer.DataAccess.EntityFramework;

public interface IEntityRepository<T> where T : class,IEntity,new()
{
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);

}