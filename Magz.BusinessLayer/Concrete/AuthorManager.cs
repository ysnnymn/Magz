using Magz.BusinessLayer.Abstract;
using Magz.DataAccessLayer.Abstract;
using Magz.EntityLayer.Concrete;

namespace Magz.BusinessLayer.Concrete;

public class AuthorManager: IAuthorService
{
    IAuthorDal _authorDal;

    public AuthorManager(IAuthorDal authorDal)
    {
        _authorDal = authorDal;
    }

    public List<Author>  TGetList()
    {
        return _authorDal.GetAll();
    }

    public Author  TGetById(int id)
    {
return    _authorDal.Get(x=>x.AuthorId==id);

    }

    public void  TAdd(Author entity)
    {
_authorDal.Add(entity);

    }

    public void  TUpdate(Author entity)
    {
_authorDal.Update(entity);

    }

    public void  TDelete(Author entity)
    {
_authorDal.Delete(entity);

    }
}