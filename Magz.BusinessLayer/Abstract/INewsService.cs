using Magz.CoreLayer.Utilities.Results;
using Magz.EntityLayer.Concrete;

namespace Magz.BusinessLayer.Abstract;

public interface INewsService:IEntityService<News>
{
    IDataResult<List<News>> GetLatestNews();
    IDataResult<List<News>> GetRandomNews();
    IDataResult<List<News>> GetHotNews();
    IDataResult<List<News>> GetPopularNews();
}