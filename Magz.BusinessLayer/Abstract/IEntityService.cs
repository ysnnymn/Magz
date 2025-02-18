using Magz.CoreLayer.Entities;
using Magz.CoreLayer.Utilities.Results;

namespace Magz.BusinessLayer.Abstract;

public interface IEntityService<T> where T : class,IEntity,new()
{
    IDataResult<List<T>> TGetList();
    IDataResult<T> TGetById(int id);
    IResult TAdd(T entity);
    IResult TUpdate(T entity);
    IResult TDelete(T entity);
   
    
}