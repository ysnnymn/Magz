using Magz.BusinessLayer.Abstract;
using Magz.DataAccessLayer.Abstract;

namespace Magz.BusinessLayer.Concrete;

public class SocialMediaManager:ISocialMediaService
{
    ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public List<SocialMedia>  TGetList()
    {
return    _socialMediaDal.GetAll();

    }

    public SocialMedia  TGetById(int id)
    {
return    _socialMediaDal.Get(x=>x.SocialMediaId == id);}

    public void  TAdd(SocialMedia entity)
    {
_socialMediaDal.Add(entity);

    }

    public void  TUpdate(SocialMedia entity)
    {
_socialMediaDal.Update(entity);

    }

    public void  TDelete(SocialMedia entity)
    {
_socialMediaDal.Delete(entity);

    }
}