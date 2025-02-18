using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.NewsViewComponents;

public class _NewsComponentPartial: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}