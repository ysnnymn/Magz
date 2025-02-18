using Magz.BusinessLayer.Abstract;
using Magz.BusinessLayer.Constants;
using Magz.CoreLayer.Utilities.Results;
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

    public IDataResult<List<Author>>  TGetList()
    {
        return new SuccessDataResult<List<Author>>(_authorDal.GetAll()); 
    }

    public IDataResult<Author>  TGetById(int id)
    {
return    new SuccessDataResult<Author>(_authorDal.Get(x=>x.AuthorId==id));

    }

    public IResult  TAdd(Author entity)
    {
_authorDal.Add(entity);
return new SuccessResult(Messages.AuthorAdded);


    }

    public IResult  TUpdate(Author entity)
    {
_authorDal.Update(entity);
return new SuccessResult(Messages.AuthorUpdated);


    }

    public IResult  TDelete(Author entity)
    {
_authorDal.Delete(entity);
return new SuccessResult(Messages.AuthorDeleted);

    }
}