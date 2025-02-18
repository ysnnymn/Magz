using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.AuthorViewComponents;

public class _JustAnotherNewsComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}