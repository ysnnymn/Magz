using Magz.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.NewsViewComponents;

public class _NewsComponentPartial: ViewComponent
{
    INewsService _newsService;

    public _NewsComponentPartial(INewsService newsService)
    {
        _newsService = newsService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _newsService.GetLatestNews();
        return View(result.Data);
    }
    
}