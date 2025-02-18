using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.NewsViewComponents;

public class _BestOfWeekComponentPartial: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}