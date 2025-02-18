using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.DefaultViewComponents;

public class _NavbarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}