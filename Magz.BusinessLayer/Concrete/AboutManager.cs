using Magz.BusinessLayer.Abstract;
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

    public List<About>  TGetList()
    {
        return _aboutDal.GetAll();
    }

    public About  TGetById(int id)
    {
       return _aboutDal.Get(x=>x.AboutId==id);
    }

    public void  TAdd(About entity)
    {
_aboutDal.Add(entity);

    }

    public void  TUpdate(About entity)
    {
_aboutDal.Update(entity);

    }

    public void  TDelete(About entity)
    {
   _aboutDal.Delete(entity);

    }
}