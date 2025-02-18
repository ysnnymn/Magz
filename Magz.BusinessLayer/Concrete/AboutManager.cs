using Magz.BusinessLayer.Abstract;
using Magz.BusinessLayer.Constants;
using Magz.CoreLayer.Utilities.Results;
using Magz.DataAccessLayer.Abstract;
using Magz.EntityLayer.Concrete;

namespace Magz.BusinessLayer.Concrete;

public class AboutManager:IAboutService
{
    IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public IDataResult<List<About>> TGetList()
    {
        return new SuccessDataResult<List<About>>(_aboutDal.GetAll());
    }

    public IDataResult<About> TGetById(int id)
    {
        return new SuccessDataResult<About>(_aboutDal.Get(x => x.AboutId == id));
        
    }

    public IResult TAdd(About entity)
    {
        _aboutDal.Add(entity);
        return new SuccessResult(Messages.AboutCreated);
    }

    public IResult TUpdate(About entity)
    {
_aboutDal.Update(entity);
return new SuccessResult(Messages.AboutUpdated);
    }

    public IResult TDelete(About entity)
    {
_aboutDal.Delete(entity);
return new SuccessResult(Messages.AboutDeleted);
    }
}