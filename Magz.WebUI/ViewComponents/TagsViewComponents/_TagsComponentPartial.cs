using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.TagsViewComponents;

public class _TagsComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}