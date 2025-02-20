using Magz.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.DefaultViewComponents;

public class _FeatureComponentPartial:ViewComponent
{
    INewsService _newsService;

    public _FeatureComponentPartial(INewsService newsService)
    {
        _newsService = newsService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _newsService.GetRandomNews();
        
        return View(result.Data.FirstOrDefault());
    }
    
}