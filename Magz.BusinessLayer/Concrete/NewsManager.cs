using Magz.BusinessLayer.Abstract;
using Magz.BusinessLayer.Constants;
using Magz.CoreLayer.Utilities.Results;
using Magz.DataAccessLayer.Abstract;
using Magz.DataAccessLayer.Context;
using Magz.EntityLayer.Concrete;

namespace Magz.BusinessLayer.Concrete;

public class NewsManager:INewsService
{
    INewsDal _newsDal;

    public NewsManager(INewsDal newsDal)
    {
        _newsDal = newsDal;
    }

    public IDataResult<List<News>>  TGetList()
    {
        return new SuccessDataResult<List<News>>(_newsDal.GetAll());
    }

    public IDataResult<News>  TGetById(int id)
    {
return  new SuccessDataResult<News>(_newsDal.Get(x=>x.NewsId == id))  ;

    }

    public IResult  TAdd(News entity)
    {
 _newsDal.Add(entity);
 return new SuccessResult(Messages.NewsAdded);

    }

    public IResult  TUpdate(News entity)
    {
_newsDal.Update(entity);
return new SuccessResult(Messages.NewsUpdated);

    }

    public IResult  TDelete(News entity)
    {
_newsDal.Delete(entity);
return new SuccessResult(Messages.NewsDeleted);

    }

    public IDataResult<List<News>> GetLatestNews()
    {

        return new SuccessDataResult<List<News>>(_newsDal.GetLatestNews());

    }

    public IDataResult<List<News>> GetRandomNews()
    {
        return new SuccessDataResult<List<News>>(_newsDal.GetRandomNews());
    }

    public IDataResult<List<News>> GetHotNews()
    {
        return new SuccessDataResult<List<News>>(_newsDal.GetHotnews());
    }

    public IDataResult<List<News>> GetPopularNews()
    {
        return new SuccessDataResult<List<News>>(_newsDal.GetPopularNews());
    }
}