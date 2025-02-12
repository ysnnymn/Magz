using Magz.BusinessLayer.Abstract;
using Magz.DataAccessLayer.Abstract;
using Magz.EntityLayer.Concrete;

namespace Magz.BusinessLayer.Concrete;

public class NewsManager:INewsService
{
    INewsDal _newsDal;

    public NewsManager(INewsDal newsDal)
    {
        _newsDal = newsDal;
    }

    public List<News>  TGetList()
    {
        return _newsDal.GetAll();
    }

    public News  TGetById(int id)
    {
return    _newsDal.Get(x=>x.NewsId == id);

    }

    public void  TAdd(News entity)
    {
 _newsDal.Add(entity);

    }

    public void  TUpdate(News entity)
    {
_newsDal.Update(entity);

    }

    public void  TDelete(News entity)
    {
_newsDal.Delete(entity);

    }
}