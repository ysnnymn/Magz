using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.DefaultViewComponents;

public class _SearchbarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}