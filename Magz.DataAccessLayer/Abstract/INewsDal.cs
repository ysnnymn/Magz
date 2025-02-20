using Magz.CoreLayer.DataAccess.EntityFramework;
using Magz.EntityLayer.Concrete;

namespace Magz.DataAccessLayer.Abstract;

public interface INewsDal:IEntityRepository<News>
{
    List<News> GetLatestNews();
    public List<News> GetRandomNews();
    List<News> GetHotnews();
    List<News> GetPopularNews();
}