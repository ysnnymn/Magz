using Magz.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.NewsViewComponents;

public class _PopularNewsComponentPartial:ViewComponent
{
    INewsService _newsService;

    public _PopularNewsComponentPartial(INewsService newsService)
    {
        _newsService = newsService;
    }

    public IViewComponentResult Invoke()
    {
        var result=_newsService.GetPopularNews();
        return View(result.Data);
    }
    
}