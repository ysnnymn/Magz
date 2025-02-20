using Magz.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.NewsViewComponents;

public class _RandomNewsComponentPartial:ViewComponent
{
    INewsService _newsService;

    public _RandomNewsComponentPartial(INewsService newsService)
    {
        _newsService = newsService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _newsService.GetRandomNews();
        return View(result.Data);
    }
    
}