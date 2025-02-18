using Magz.BusinessLayer.Abstract;
using Magz.CoreLayer.Utilities.Results;
using Magz.DataAccessLayer.Abstract;

namespace Magz.BusinessLayer.Concrete;

public class SocialMediaManager:ISocialMediaService
{
    ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public IDataResult<List<SocialMedia>>  TGetList()
    {
return  new SuccessDataResult<List<SocialMedia>>(_socialMediaDal.GetAll())  ;

    }

    public IDataResult<SocialMedia>  TGetById(int id)
    {
return new SuccessDataResult<SocialMedia>(_socialMediaDal.Get(x=>x.SocialMediaId == id))   ;

    }

    public IResult  TAdd(SocialMedia entity)
    {
_socialMediaDal.Add(entity);
return new SuccessResult();

    }

    public IResult  TUpdate(SocialMedia entity)
    {
_socialMediaDal.Update(entity);
return new SuccessResult();

    }

    public IResult  TDelete(SocialMedia entity)
    {
_socialMediaDal.Delete(entity);
return new SuccessResult();

    }
}