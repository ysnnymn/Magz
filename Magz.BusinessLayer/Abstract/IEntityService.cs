using Magz.CoreLayer.Entities;

namespace Magz.BusinessLayer.Abstract;

public interface IEntityService<T> where T : class,IEntity,new()
{
    List<T> TGetList();
    T TGetById(int id);
    void TAdd(T entity);
    void TUpdate(T entity);
    void TDelete(T entity);
   
    
}