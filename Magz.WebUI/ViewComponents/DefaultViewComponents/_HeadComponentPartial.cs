using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.DefaultViewComponents;

public class _HeadComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}