using Magz.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.NewsViewComponents;

public class _HotNewsComponentPartial:ViewComponent
{
    INewsService _newsService;

    public _HotNewsComponentPartial(INewsService newsService)
    {
        _newsService = newsService;
    }

    public IViewComponentResult Invoke()
    {
        var result=_newsService.GetHotNews();
        return View(result.Data);
    }
    
}