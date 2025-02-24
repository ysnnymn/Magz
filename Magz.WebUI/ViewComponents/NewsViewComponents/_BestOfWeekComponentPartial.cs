using Magz.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.NewsViewComponents;

public class _BestOfWeekComponentPartial: ViewComponent
{
    INewsService _newsService;

    public _BestOfWeekComponentPartial(INewsService newsService)
    {
        _newsService = newsService;
    }

    public IViewComponentResult Invoke()
    {
        var ressult = _newsService.GetPopularNews();
        return View(ressult.Data);
    }
    
}