using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.DefaultViewComponents;

public class _FooterComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}