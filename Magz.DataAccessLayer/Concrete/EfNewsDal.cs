using Magz.CoreLayer.DataAccess.EntityFramework;
using Magz.DataAccessLayer.Abstract;
using Magz.DataAccessLayer.Context;
using Magz.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Magz.DataAccessLayer.Concrete;

public class EfNewsDal:EfEntityRepositoryBase<News,MagzContext>,INewsDal
{
    public List<News> GetLatestNews()
    {
        using var context = new MagzContext();
        return context.News
            .Include(n => n.Category) // Category'yi yükler
            .OrderByDescending(n => n.CreatedDate) // En son eklenen haberleri sırala
            .Take(4) // 4 tane getir
            .ToList();
    }

    public List<News> GetRandomNews()
    {
        using (MagzContext context = new MagzContext())
        {
            return context.News
                .OrderBy(r => Guid.NewGuid()) // Rastgele sıralama
                 // Belirtilen kadar haber al
                .Include(n => n.Category) // Kategori bilgisini de çek
                .ToList();        }
    }

    public List<News> GetHotnews()
    {
        using (MagzContext context = new MagzContext())
        {
            return  context.News.Include(x=>x.Category).OrderByDescending(x=>x.CreatedDate).ToList();
        }
    }

    public List<News> GetPopularNews()
    {
        using (MagzContext context = new MagzContext())
        {
            return context.News.Include(x=>x.Category).OrderByDescending(x=>x.LikeCount).ToList();
        }
    }
}